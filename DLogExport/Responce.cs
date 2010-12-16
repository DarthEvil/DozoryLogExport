using System;
using System.Collections.Generic;
using System.Linq;
using DozorySharp;

namespace DLogExport
{
    /// <summary>
    /// Описывает результат импорта данных
    /// </summary>
    class Responce
    {
        private readonly OrgAuth _org;
        private readonly DateTime _begin;
        private readonly DateTime _end;
        private Dictionary<StorageType, List<StorageOperation>> _storages;
        private Dictionary<TreasureType, List<TreasureOperation>> _treasures;

        /// <summary>
        /// Создатель класса
        /// </summary>
        /// <param name="org">Данные об организации</param>
        /// <param name="begin">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        public Responce(OrgAuth org, DateTime begin, DateTime end)
        {
            _org = org;
            _end = end;
            _begin = begin;

            _storages = new Dictionary<StorageType, List<StorageOperation>>();
            _treasures = new Dictionary<TreasureType, List<TreasureOperation>>();
        }

        /// <summary>
        /// Получаем список складов, на которіе выбирались логи
        /// </summary>
        public List<StorageType> GetStoragesList
        {
            get{return _storages.Keys.ToList();}
        }

        /// <summary>
        /// Получаем список депозитов, на которіе выбирались логи
        /// </summary>
        public List<TreasureType> GetTreasutesList
        {
            get{return _treasures.Keys.ToList();}
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
        /// Получаем операции склада
        /// </summary>
        /// <param name="type">Тип склада</param>
        /// <returns></returns>
        public List<StorageOperation> GetStorage(StorageType type)
        {
            List<StorageOperation> result = new List<StorageOperation>();

            if (_storages.ContainsKey(type))
            {
                result = _storages[type];
            }

            return result;
        }

        /// <summary>
        /// Получаем операции казны
        /// </summary>
        /// <param name="type">Тип казны</param>
        /// <returns></returns>
        public List<TreasureOperation> GetTreasute(TreasureType type)
        {
            List<TreasureOperation> result = new List<TreasureOperation>();

            if (_treasures.ContainsKey(type))
            {
                result = _treasures[type];
            }

            return result;
        }

        /// <summary>
        /// Добавляет операции в список соответствующего склада
        /// </summary>
        /// <param name="type">Тип склада</param>
        /// <param name="operations">Список операции</param>
        public void AddStorageDay(StorageType type, List<StorageOperation> operations)
        {
            //если склада нет - создаем
            if (!_storages.ContainsKey(type)){
                _storages.Add(type, new List<StorageOperation>());
            }
            //Добавляем операции
            foreach (StorageOperation item in operations)
            {
                _storages[type].Add(item);
            }

        }

        /// <summary>
        /// Добавляет операции в список соответствующего склада
        /// </summary>
        /// <param name="type">Тип склада</param>
        /// <param name="operations">Список операции</param>
        public void AddTreasureDay(TreasureType type, List<TreasureOperation> operations)
        {
            //если склада нет - создаем
            if (!_treasures.ContainsKey(type))
            {
                _treasures.Add(type, new List<TreasureOperation>());
            }
            //Добавляем операции
            foreach (TreasureOperation item in operations)
            {
                _treasures[type].Add(item);
            }

        }
    }
}
