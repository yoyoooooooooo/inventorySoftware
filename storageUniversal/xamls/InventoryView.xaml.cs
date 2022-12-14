﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Data;
using System.Xml;
using storageUniversal;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Collections.ObjectModel;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// a page where user can menege is current inventory 
    /// </summary>
    public sealed partial class InventoryView : Page
    {
        public List<InventoryRow> InventoryBeforeChange;// original inventory
        public ObservableCollection<InventoryRow> InventoryRowesBindedToUser = new ObservableCollection<InventoryRow>();
        public static UserDBServ.User FullUser = login.FullUser;//the user that activly uses the page;
        public static Type SentFrom;//the page from which the user were sent
        public static InventoryRow LantItem;
        public InventoryView()
        {
            this.InitializeComponent();
            LoadTblFunc();
        }

        private void InventoryTbl_ItemClick(object sender, ItemClickEventArgs e)
        {


        }

        private void LoadTbl_Click(object sender, RoutedEventArgs e)
        {
            LoadTblFunc();
        }

        private async void LoadTblFunc()
        {
            InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
            var broww = new BorowwDb.BorowwingsDBSoapClient();
            var hasCalcWorked = await broww.UpdateUserAmountOutAsync(FullUser.ID);
            var r = await s.GetInventoryUserDataTableAsync(FullUser.ID);
            List<InventoryRow> inventoryRows = new List<InventoryRow>();
            foreach (DataRow dr in r.Rows) {
                InventoryRow row = new InventoryRow();
                if (dr["Name"].ToString() != "")
                    row.Name = dr["Name"].ToString();
                row.ID = int.Parse(dr["ID"].ToString());
                if(dr["NeededQuantity"].ToString() != "")
                    row.NeededQuantity = float.Parse(dr["NeededQuantity"].ToString());
                row.OwnerUserId = int.Parse(dr["OwnerUserId"].ToString());
                if (dr["Quantity"].ToString() != "")
                    row.Quantity = float.Parse(dr["Quantity"].ToString());
                if (dr["Remarkes"].ToString() != "")
                    row.Remarkes = dr["Remarkes"].ToString();
                if (dr["AmountOut"].ToString() != "")
                    row.AmountOut = float.Parse(dr["AmountOut"].ToString());
                inventoryRows.Add(row);
            }
            foreach(InventoryRow Row in inventoryRows)
            {
                InventoryRowesBindedToUser.Add(Row);
            }
            InventoryTbl.ItemsSource = InventoryRowesBindedToUser;
            InventoryBeforeChange = new List<InventoryRow>();
            foreach (InventoryRow Row in inventoryRows)
            {
                InventoryBeforeChange.Add(Row.copy());
            }
            
        }

        private void UpdateDataFromTbl_Click(object sender, RoutedEventArgs e)
        {
            UpdateDataToDB();
        }
        private async void UpdateDataToDB()
        {
            InventoryRow sel = (InventoryRow)InventoryTbl.SelectedItem;
            ItemCollection ic = InventoryTbl.Items;
            List<InventoryRow> inventoryRows = new List<InventoryRow>();
            int len = 0;
            foreach (InventoryRow a in ic)
            {
                len++;
                InventoryRow ro = new InventoryRow();
                ro.Name = a.Name;
                ro.Quantity = a.Quantity;
                ro.NeededQuantity = a.NeededQuantity;
                ro.ID = a.ID;
                ro.Remarkes = a.Remarkes;
                inventoryRows.Add(ro);
            }

            foreach (InventoryRow a in inventoryRows)
            {
                InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
                foreach (InventoryRow original in InventoryBeforeChange)
                {
                    if (a.ID == original.ID)
                    {

                        if (a.Equal(original))
                        {
                            break;
                        }
                        else
                        {
                            InventoryServ.InventoryRow row = new InventoryServ.InventoryRow();
                            row.ID = a.ID;
                            row.Name = a.Name;
                            row.Quantity = a.Quantity;
                            row.NeededQuantity = a.NeededQuantity;
                            row.Remarkes = a.Remarkes;
                            bool isOk = await s.changeInventoryRowAsync(row);
                        }
                    }
                }

            }
        }

        private async void Delete_Click(object sender, RoutedEventArgs e)
        {
            InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
            int index = InventoryTbl.SelectedIndex;
            int id = ((InventoryRow)InventoryTbl.Items[index]).ID;
            bool res = await s.DeleteInventoryRowAsync(id);
            LoadTblFunc();
        }
        //responds to click by adding item to ListView
        private async void AddItem_Click(object sender, RoutedEventArgs e)
        {
            InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
            InventoryRow NewRow = new InventoryRow();
            var ItemId = await s.getNewItemIdAsync(FullUser.ID);
            NewRow.ID = int.Parse(ItemId.ToString());
            NewRow.OwnerUserId = FullUser.ID;
            InventoryRowesBindedToUser.Add(NewRow);
            InventoryBeforeChange.Add(NewRow.copy());

        }
        //rwcives a new InventoryRow and add new item to the ListView, and to db
        private async void addItemFunc(InventoryRow a)
        {
            InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
            InventoryRow NewRow = a;
            var ItemId = await s.getNewItemIdAsync(FullUser.ID);
            NewRow.ID = int.Parse(ItemId.ToString());
            NewRow.OwnerUserId = FullUser.ID;
            InventoryRowesBindedToUser.Add(NewRow);
            InventoryTbl.ItemsSource = null;
            InventoryTbl.ItemsSource = InventoryRowesBindedToUser;
            InventoryBeforeChange.Add(NewRow.copy());
        }
        //import inventory list from csv file
        private async void CsvImport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var picker = new Windows.Storage.Pickers.FileOpenPicker();
                picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
                picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
                picker.FileTypeFilter.Add(".csv");
                Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
                var randomAccessStream = await file.OpenReadAsync();
                Stream stream = randomAccessStream.AsStreamForRead();
                StreamReader reader = new StreamReader(stream);
                List<InventoryRow> inventoryRows = new List<InventoryRow>();
                using (reader)
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        //define pattern
                        Regex csvparser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                        //separating columns to array
                        string[] x = csvparser.Split(line);

                        /* do something with x */
                        InventoryRow row = new InventoryRow();
                        row.Name = x[0];
                        row.Quantity = float.Parse(x[1]);
                        row.NeededQuantity = float.Parse(x[2]);
                        row.Remarkes = x[3];
                        row.OwnerUserId = FullUser.ID;
                        inventoryRows.Add(row);
                    }
                }
                foreach (InventoryRow row in inventoryRows)
                {
                    addItemFunc(row);
                }
                UpdateDataToDB();
            }
            catch { }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(SentFrom);
        }
        //reviles add landing menu after clicking add landing button
        private async void LandButton_Click(object sender, RoutedEventArgs e)
        {
            Grid grid = new Grid();
            var rowDefinitions = grid.RowDefinitions;
            int i = 2;
            for(int j=0; j<i; j++)
            {
                rowDefinitions.Add(new RowDefinition());
            }
            TextBox amount = new TextBox { PlaceholderText = "amount" };
            Grid.SetRow(amount, 0); grid.Children.Add(amount); 
            TextBox lentTo = new TextBox { PlaceholderText = "Lent to" };
            Grid.SetRow(lentTo, 1); grid.Children.Add(lentTo);
            ContentDialog getLandingDits = new ContentDialog()
            {
                Title = "please fill out the landing ditails",
                Content = grid,
                SecondaryButtonText = "save",
                SecondaryButtonCommandParameter= grid, SecondaryButtonCommand=new saveBtnCmd(),
                CloseButtonText = "cancel"
            };
            await getLandingDits.ShowAsync();
            LoadTblFunc();
        }
        //reviles add landing button after right clicking an item
        private void Gridy_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            if (InventoryTbl.SelectedItem != null)
            {
                LantItem = InventoryTbl.Items[InventoryTbl.SelectedIndex] as InventoryRow;
                MenuFlyout rightClick = new MenuFlyout();
                MenuFlyoutItem firstItem = new MenuFlyoutItem { Text = "land out" };
                firstItem.Click += LandButton_Click;
                rightClick.Items.Add(firstItem);
                UIElement b = sender as UIElement;
                b.ContextFlyout = rightClick;
                Point point = new Point(e.GetPosition(b).X, e.GetPosition(b).Y);
                rightClick.ShowAt(b, point);
            }


        }
        //the command for adding a landing
        class saveBtnCmd : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                throw new NotImplementedException();
            }

            public async void Execute(object parameter)
            {
                UIElement content = parameter as UIElement;
                float amount = float.Parse(((content as Grid).Children[0] as TextBox).Text);
                string lentTo = ((content as Grid).Children[1] as TextBox).Text;
                var s = new BorowwDb.BorowwingsDBSoapClient();
                var id = await s.AddLendingAsync(LantItem.ID, lentTo, DateTime.Now, amount, FullUser.ID);
                var b = s.UpdateAmountOutAsync(LantItem.ID);
                
                
            }
        }
        //takes the user to a page where he can see all of his active landings
        private void SeeLandings_Click(object sender, RoutedEventArgs e)
        {
            BrowwingsAndDistractions.user = FullUser;
            BrowwingsAndDistractions.senderPage = typeof(InventoryView);
            Frame.Navigate(typeof(BrowwingsAndDistractions));
        }
    }
}
