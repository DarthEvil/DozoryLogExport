using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DozorySharp;

namespace DLogExport
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void BtnImportClick(object sender, EventArgs e)
        {
            DateTime begin = dtp_begin.Value;
            DateTime end = dtp_end.Value;
            OrgAuth auth = null;
            int sources = 0;

            if (!bgw.IsBusy){
                //Начинаем импорт
                try
                {
                    //Создаем авторизовывалку

                    if (tb_id.Value != 0 && !String.IsNullOrEmpty(tb_pass.Text))
                    {
                        auth = new OrgAuth((int)tb_id.Value, tb_pass.Text);
                    }
                    else{
                        MessageBox.Show("Не указан логин или пароль доступа к данным", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Собираем список складов
                    List<StorageType> storages = new List<StorageType>();
                    if (ch_storage_main.Checked) { storages.Add(StorageType.Main);sources++; }
                    if (ch_storage_second.Checked) { storages.Add(StorageType.Second); sources++; }
                    if (ch_storage_mods.Checked) { storages.Add(StorageType.Mods); sources++; }
                    if (ch_storage_prof.Checked) { storages.Add(StorageType.Prof); sources++; }
                    if (ch_storage_lib.Checked) { storages.Add(StorageType.Lib); sources++; }

                    //Собираем список казн
                    List<TreasureType> treasures = new List<TreasureType>();
                    if (ch_treasure_money.Checked) { treasures.Add(TreasureType.Money); sources++; }
                    if (ch_treasure_taler.Checked) { treasures.Add(TreasureType.Taler); sources++; }

                    int days = (end - begin).Days + 1;

                    if (days < 1)
                    {
                        MessageBox.Show("Некорректно указан диапазон дат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (sources == 0)
                    {
                        MessageBox.Show("Не выбран не один из доступных источников", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    progress.Maximum = sources*days;

                    //Отключаем контролы
                    gb_org.Enabled = false;
                    gb_dates.Enabled = false;
                    gb_sources.Enabled = false;
                    //gb_control.Enabled = false;

                    progress.Value = 0;
                    bgw.RunWorkerAsync(new Reqest(begin, end, storages, treasures, auth));
                    btn_import.Text = "Прервать импорт";
                }
                catch (Exception exception){
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else{
                //отменяем импорт
                if (MessageBox.Show("Прервать импорт данных?", "Необходимо подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK){
                    bgw.CancelAsync();
                    btn_import.Text = "Начать импорт";
                }
            }
            
            //Загрузка: Профессиональный - 21.11.2010
        }

        private void ChAllStorageCheckedChanged(object sender, EventArgs e)
        {
            if (ch_all_storage.CheckState == CheckState.Checked)
            {
                //Устанавливаем все
                ch_storage_main.Checked = true;
                ch_storage_second.Checked = true;
                ch_storage_mods.Checked = true;
                ch_storage_prof.Checked = true;
                ch_storage_lib.Checked = true;
            }
            else if (ch_all_storage.CheckState == CheckState.Unchecked)
            {
                //Снимаем все
                ch_storage_main.Checked = false;
                ch_storage_second.Checked = false;
                ch_storage_mods.Checked = false;
                ch_storage_prof.Checked = false;
                ch_storage_lib.Checked = false;

            }
        }

        private void ChStorageMainCheckedChanged(object sender, EventArgs e)
        {
            if (ch_storage_main.Checked && ch_storage_second.Checked && ch_storage_mods.Checked && ch_storage_prof.Checked && ch_storage_lib.Checked){
                //Если установлены все
                ch_all_storage.CheckState = CheckState.Checked;
            }
            else if (!ch_storage_main.Checked && !ch_storage_second.Checked && !ch_storage_mods.Checked && !ch_storage_prof.Checked && !ch_storage_lib.Checked){
                //Если сняты все
                ch_all_storage.CheckState = CheckState.Unchecked;
            }
            else{
                //Частично
                ch_all_storage.CheckState = CheckState.Indeterminate;
            }
        }

        private void ChAllTreasureCheckedChanged(object sender, EventArgs e)
        {
            if (ch_all_treasure.CheckState == CheckState.Checked)
            {
                //Устанавливаем все
                ch_treasure_money.Checked = true;
                ch_treasure_taler.Checked = true;
            }
            else if (ch_all_treasure.CheckState == CheckState.Unchecked)
            {
                //Снимаем все
                ch_treasure_money.Checked = false;
                ch_treasure_taler.Checked = false;
            }
        }

        private void ChTreasureTalerCheckedChanged(object sender, EventArgs e)
        {
            if (ch_treasure_money.Checked && ch_treasure_taler.Checked)
            {
                //Если установлены все
                ch_all_treasure.CheckState = CheckState.Checked;
            }
            else if (!ch_treasure_money.Checked && !ch_treasure_taler.Checked)
            {
                //Если сняты все
                ch_all_treasure.CheckState = CheckState.Unchecked;
            }
            else
            {
                //Частично
                ch_all_treasure.CheckState = CheckState.Indeterminate;
            }
        }

        private void BgwDoWork(object sender, DoWorkEventArgs e)
        {
            Reqest parameters = (Reqest) e.Argument;
            Responce result = new Responce(parameters.Org, parameters.BeginTime, parameters.EndTime);

            DateTime now = parameters.BeginTime;

                //Перебираем склады
            Parallel.ForEach(parameters.Storages, type =>
                    {
                        now = parameters.BeginTime;
                        int days = (int)(parameters.EndTime.Date - now.Date).TotalDays;
                        if (days == 0) days = 1;
                        Parallel.For(0, days, i =>
                                {
                                    try
                                    {
                                        result.AddStorageDay(type,
                                                            DozoryApi.GetStorageDay(
                                                                parameters.Org, now, type));
                                    }
                                    catch (Exception exception)
                                    {
                                        if (exception.Message != "Нет данных")
                                        {
                                            throw;
                                        }
                                    }
                                    finally
                                    {
                                        bgw.ReportProgress(0);
                                        now = now.AddDays(1);
                                    }
                                }
                            );
                    }
                );

            Parallel.ForEach(parameters.Treasures, type =>
                    {
                        now = parameters.BeginTime;
                        int days = (int)(parameters.EndTime.Date - now.Date).TotalDays;
                        if (days == 0) days = 1;
                        Parallel.For(0, days, i =>
                                {
                                    try
                                    {
                                        result.AddTreasureDay(type,
                                                                DozoryApi.GetTreasureDay(
                                                                    parameters.Org, now, type));
                                    }
                                    catch (Exception exception)
                                    {
                                        if (exception.Message != "Нет данных")
                                        {
                                            throw;
                                        }
                                    }
                                    finally
                                    {
                                        bgw.ReportProgress(0);
                                        now = now.AddDays(1);
                                    }
                                }
                            );
                    }
                );
            e.Result = result;
        }

        private void BgwRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null){
                //Выпали по ошибке
                MessageBox.Show(e.Error.Message, "Операция прервана", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Cancelled){
                //Остановили сами
                MessageBox.Show("Импорт данных прекращен", "Операция прервана", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Тут у нас нормальное завершение
                    progress.Value = progress.Maximum;

                    //И создаем отчет
                    Responce result = (Responce) e.Result;

                    ReportGenerator report = new ReportGenerator();
                    string filename = Application.StartupPath+"\\Отчеты\\" + DateTime.Now.Ticks + ".xlsx";
                    report.Generate(filename, result);
                    //Directory.Delete("Отчеты\\xl",true);
                    //Directory.Delete("Отчеты\\docProps", true);
                    Process.Start(filename);
                    progress.Value = 0;
                }
                catch(Exception exc)
                {
                    MessageBox.Show(this, exc.Message, "Ошибка!", MessageBoxButtons.OK);
                }
            }

            //Возвращаем рожу к стартовому состоянию
            

            btn_import.Text = "Начать импорт";
            //Включаем контролы
            gb_org.Enabled = true;
            gb_dates.Enabled = true;
            gb_sources.Enabled = true;
            gb_control.Enabled = true;
        }

        private void BgwProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value++;
        }
    }
}
