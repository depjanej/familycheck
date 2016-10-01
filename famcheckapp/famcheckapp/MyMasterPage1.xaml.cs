using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace famcheckapp
{
    public partial class MyMasterPage1 : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MyMasterPage1()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                IconSource = "contacts.png",
                TargetType = typeof(MyDetailsPage1)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                IconSource = "todo.png",
                TargetType = typeof(MyDetailsPage1)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                IconSource = "reminders.png",
                TargetType = typeof(MyDetailsPage1)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
