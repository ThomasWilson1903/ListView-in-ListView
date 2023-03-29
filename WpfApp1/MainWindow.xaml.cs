using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.DataBase;
using WpfApp1.DataBase.Entity;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            select();
        }

        class dwqd
        {
            public DateOnly data { get; set; }

            public List<das> name { get; set; }

        }

        class das
        {
            public string nameSub { get; set; }
            public int AccessSub { get; set; }
        }

        void select()
        {
            IEnumerable<dwqd> list = new List<dwqd>
            {
                
                new dwqd
                {
                    data = new DateOnly(2023, 03,29),
                    name = new List<das>
                    {
                        new das
                        {
                            nameSub = "Биология",
                            AccessSub = 2,
                        },
                        new das
                        {
                            nameSub = "История",
                            AccessSub = 3,
                        },
                        new das
                        {
                            nameSub = "Алгебра",
                            AccessSub = 5,
                        }
                    }
                },
                new dwqd
                {
                    data = new DateOnly(2023, 03,30),
                    name = new List<das>
                    {
                        new das
                        {
                            nameSub = "Биология",
                            AccessSub = 2,
                        },
                        new das
                        {
                            nameSub = "История",
                            AccessSub = 3,
                        },
                        new das
                        {
                            nameSub = "Алгебра",
                            AccessSub = 5,
                        }
                    }
                }
            };
            //IEnumerable<dwqd> list  = EfModels.init().Journals.Include(p=>p.ListItemsNavigation).ToList();
            lvMain.ItemsSource = list;
        }
    }
}
