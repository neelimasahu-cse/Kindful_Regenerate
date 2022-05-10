using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MulitipleViews.Views
{
    /// <summary>
    /// Interaction logic for ClothesView.xaml
    
    /// </summary>
    public partial class ClothesView : UserControl
    {
        public ClothesView()
        {
            InitializeComponent();
            articlesizeCb.Visibility = Visibility.Collapsed;
            genderCb.Visibility = Visibility.Collapsed;
        }

        //parameters from front end to fire search upon

        public string clothType { get; set; }
        public string clothSize { get; set; }
        public string gender { get; set; }
        int quantity { get; set; }
        
        public List<Cloth> clothesList { get; set; } = Clothes.GetAllClothes();

        public void ClothType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(articleTypeCb.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last());
            clothType = articleTypeCb.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last();
            articlesizeCb.Visibility = Visibility.Visible;
        }
        public void ClothSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // MessageBox.Show(articlesizeCb.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last());
            clothSize = articlesizeCb.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last();
            genderCb.Visibility = Visibility.Visible;
            
        }
        public void Gender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // MessageBox.Show(genderCb.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last());
            clothSize = articlesizeCb.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last();
           
        }


        
        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    userInformation user = new userInformation();
                    user.RecieverName = txtbox1.Text;
                    user.PhoneNumber = Int32.Parse(txtbox2.Text);
                    user.Quantity = Int32.Parse(txtbox3.Text);
                    

                   SaveXML.savedata(user, "userInformation.xml");

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void Donatebtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }

    //1. create a class
    public class Clothes
    {
        public static List<Cloth> GetAllClothes()
        {

            var allClothesList = new List<Cloth>();
            allClothesList.Add(new Cloth() { gender = "female", type = "Jacket", size = "XS", quantity = "10" });
            allClothesList.Add(new Cloth() { gender = "male", type = "Jacket", size = "XL", quantity = "10" });
            allClothesList.Add(new Cloth() { gender = "kids", type = "Jacket", size = "XS", quantity = "10" });
            allClothesList.Add(new Cloth() { gender = "male", type = "Jacket", size = "S", quantity = "10" });
            return allClothesList;

        }

    }

}
