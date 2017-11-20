using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBModel
{
    public class Restaurant : Entity
    {
        private string name;
        //TODO: A menu class can be seperate further containing the hierarchy. For simplicity assuming menu is list of items.
        private List<Item> menu;
        private string location;
        private string description;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<Item> Menu
        {
            get
            {
                return menu;
            }

            set
            {
                menu = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }
}
