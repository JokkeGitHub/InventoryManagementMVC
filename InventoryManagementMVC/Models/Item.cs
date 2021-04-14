using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementMVC.Models
{
    public class Item
    {
        private string _username;
        private string _section;
        private string _row;
        private string _drawer;
        private string _room;
        private string _product;
        private int _amount;
        private string _type;
        private string _supplier;
        private string _supplierNumber;
        private string _description;

        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }

        public string Section
        {
            get
            {
                return this._section;
            }
            set
            {
                this._section = value;
            }
        }
        public string Row
        {
            get
            {
                return this._row;
            }
            set
            {
                this._row = value;
            }
        }
        public string Drawer
        {
            get
            {
                return this._drawer;
            }
            set
            {
                this._drawer = value;
            }
        }
        public string Room
        {
            get
            {
                return this._room;
            }
            set
            {
                this._room = value;
            }
        }
        public string Product
        {
            get
            {
                return this._product;
            }
            set
            {
                this._product = value;
            }
        }
        public int Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        public string Supplier
        {
            get
            {
                return this._supplier;
            }
            set
            {
                this._supplier = value;
            }
        }
        public string SupplierNumber
        {
            get
            {
                return this._supplierNumber;
            }
            set
            {
                this._supplierNumber = value;
            }
        }
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public Item(string username, string section, string row, string drawer, string room, string product, int amount, string type, string supplier, string supplierNumber, string description)
        {
            Username = username;
            Section = section;
            Row = row;
            Drawer = drawer;
            Room = room;
            Product = product;
            Amount = amount;
            Type = type;
            Supplier = supplier;
            SupplierNumber = supplierNumber;
            Description = description;
        }
    }
}
