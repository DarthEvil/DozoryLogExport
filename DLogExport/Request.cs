using System;
using System.Collections.Generic;
using DozorySharp;

namespace DLogExport
{
    /// <summary>
    /// Описывает запрос на импорт данных
    /// </summary>
    class Reqest
    {
        private readonly OrgAuth _org;
        private readonly DateTime _begin;
        private readonly DateTime _end;
        private readonly List<StorageType> _storages;
        private readonly List<TreasureType> _treasures;

        /// <summary>
        /// Создатель
        /// </summary>
        /// <param name="begin">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <param name="storages">Перечень складов</param>
        /// <param name="treasures">Перечень казн</param>
        /// <param name="org">Данные организации</param>
        public Reqest(DateTime begin, DateTime end, List<StorageType> storages, List<TreasureType> treasures, OrgAuth org)
        {
            _begin = begin;
            _treasures = treasures;
            _storages = storages;
            _end = end;
            _org = org;
        }

        /// <summary>
        /// Данные организации
        /// </summary>
        public OrgAuth Org
        {
            get { return _org; }
        }

        /// <summary>
        /// Начальная дата
        /// </summary>
        public DateTime BeginTime
        {
            get { return _begin; }
        }

        /// <summary>
        /// Конечная дата
        /// </summary>
        public DateTime EndTime
        {
            get { return _end; }
        }

        /// <summary>
        /// Перечень складов
        /// </summary>
        public List<StorageType> Storages
        {
            get { return _storages; }
        }

        /// <summary>
        /// Перечень казн
        /// </summary>
        public List<TreasureType> Treasures
        {
            get { return _treasures; }
        }
    }
}
