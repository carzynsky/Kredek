using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiA
{
    public partial class FormDatabase : Form
    {
        // Kontekst do bazy danych
        NORTHWNDEntities _context = new NORTHWNDEntities();

        // Zmienna przechowująca operację do wykonania, 1 - pokaz pracowników na 'm', 2 - pokaz produkty,
        // których cena jednostkowa zawiera się między 8 a 22
        int operation;
        /// <summary>
        /// Konstruktor klasy FormDatabase
        /// </summary>
        /// <param name="operation"></param>
        public FormDatabase(int operation)
        {
            InitializeComponent();
            this.operation = operation;
        }

        /// <summary>
        /// Funkcja wywoływana podczas załadowania okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormsDatabase_Load(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 1:
                default:
                    {
                        var employees = _context.Employees.Where(x => x.FirstName.StartsWith("M")).ToList();
                        dataGridViewDatabase.DataSource = employees;
                        break;
                    }
                case 2:
                    {
                        var products = (from p in _context.Products
                                        where p.UnitPrice >= 8 && p.UnitPrice <= 22
                                        select p).OrderByDescending(x => x.UnitPrice).ToList();
                        dataGridViewDatabase.DataSource = products;
                        break;
                    }
            }
            
        }
    }
}
