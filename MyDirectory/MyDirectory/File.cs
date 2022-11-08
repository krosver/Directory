// Проект по созданию модели логической файловой системы 
// Дочерний класс MyObject, созданный для указания конкретного типа созданного объекта (File)
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDirectory
{
    class File : MyObject
    {
        public File(string name, MyObject parent, int weight) : base(name, parent)
        {
            this._Weight = weight;
        }
    }
}
