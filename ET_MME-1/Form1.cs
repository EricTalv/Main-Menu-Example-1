using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ET_MME_1
{
    public partial class Form1 : Form
    {

        //Defining Global LISTS
        List<List_Category> category = new List<List_Category>();
        List<Items> items = new List<Items>();

        //CREATE LIST
        public class List_Category
        {
            public int CategoryIndex { get; set; }
            public String CategoryName { get; set; }
        }

        public class Items
        {
            public int CategoryIndex { get; set; }
            public String ItemName { get; set; }
            public String ItemDesc { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            Component_Data();
        }

        //DEFINE THE DATA
        private void Component_Data()
        {
            category.Add(new List_Category { CategoryIndex = 0, CategoryName = "Cars" });
            category.Add(new List_Category { CategoryIndex = 1, CategoryName = "Architects" });
            category.Add(new List_Category { CategoryIndex = 2, CategoryName = "Guitarists" });

            items.Add(new Items { CategoryIndex = 0, ItemName = "GAZ", ItemDesc = "GAZ or Gorkovsky Avtomobilny Zavod is a Russian automotive manufacturer located in Nizhny Novgorod. It started in 1932 as NAZ, a cooperative enterprise between Ford and the Soviet Union, as a result of a Five year plan" });
            items.Add(new Items { CategoryIndex = 0, ItemName = "Ikarus", ItemDesc = "Ikarus is a bus manufacturer based in Budapest, Hungary. It was established in 1895 as Uhri Imre Kovács- és Kocsigyártó Üzeme." });
            items.Add(new Items { CategoryIndex = 0, ItemName = "Dodge", ItemDesc = "Dodge is an American brand of automobile manufactured by Fiat Chrysler, based in Auburn Hills, Michigan." });

            items.Add(new Items { CategoryIndex = 1, ItemName = "Frank Lloyd Wright", ItemDesc = "Frank Lloyd Wright was an American architect, interior designer, writer and educator, who designed more than 1,000 structures, 532 of which were completed." });
            items.Add(new Items { CategoryIndex = 1, ItemName = "Ludwig Mies van der Rohe", ItemDesc = "Ludwig Mies van der Rohe was a German-American architect. He is commonly referred to and was addressed as Mies, his surname." });
            items.Add(new Items { CategoryIndex = 1, ItemName = "Le Corbusier", ItemDesc = "Charles-Édouard Jeanneret, known as Le Corbusier, was a Swiss-French architect, designer, painter, urban planner, writer, and one of the pioneers of what is now called modern architecture." });

            items.Add(new Items { CategoryIndex = 2, ItemName = "Jimi Hendrix", ItemDesc = "James Marshall 'Jimi' Hendrix was an American rock guitarist, singer, and songwriter. Although his mainstream career spanned only four years, he is widely regarded as one of the most influential electric ... " });
            items.Add(new Items { CategoryIndex = 2, ItemName = "Eric Clapton", ItemDesc = "Eric Patrick Clapton, CBE, is an English rock and blues guitarist, singer, and songwriter. He is the only three-time inductee to the Rock and Roll Hall of Fame: once as a solo artist and separately as a member of the Yardbirds and of Cream." });
            items.Add(new Items { CategoryIndex = 2, ItemName = "Stevie Ray Vaughan", ItemDesc = "Stephen Ray Vaughan was an American musician, singer, songwriter, and record producer. In spite of a short-lived mainstream career spanning seven years, he was one of the most influential guitarists in the revival of blues in the 1980s." });

            CBX_Categories.DisplayMember = "CategoryName";
            CBX_Categories.ValueMember = "CategoryIndex";

            CBX_Categories.DataSource = category;

            CBX_Categories.DropDownStyle = ComboBoxStyle.DropDownList;

            LBX_Choices.DisplayMember = "ItemName";
            LBX_Choices.ValueMember = "CategoryIndex";
        }

        //CATEGORY ELEMENTS
        private void CBX_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Items> tempItems = new List<Items>();

            switch (Convert.ToInt32(CBX_Categories.SelectedValue))
            {
                case 0:
                    var item = items.Where(cat => cat.CategoryIndex == 0);

                    foreach (var i in item)
                    {
                        tempItems.Add(new Items { CategoryIndex = i.CategoryIndex, ItemDesc = i.ItemDesc, ItemName = i.ItemName });
                    }
                    break;
                case 1:
                    item = items.Where(cat => cat.CategoryIndex == 1);

                    foreach (var i in item)
                    {
                        tempItems.Add(new Items { CategoryIndex = i.CategoryIndex, ItemDesc = i.ItemDesc, ItemName = i.ItemName });
                    }
                    break;

                case 2:
                    item = items.Where(cat => cat.CategoryIndex == 2);

                    foreach (var i in item)
                    {
                        tempItems.Add(new Items { CategoryIndex = i.CategoryIndex, ItemDesc = i.ItemDesc, ItemName = i.ItemName });
                    }
                    break;

                case 3:
                    item = items.Where(cat => cat.CategoryIndex == 3);

                    foreach (var i in item)
                    {
                        tempItems.Add(new Items { CategoryIndex = i.CategoryIndex, ItemDesc = i.ItemDesc, ItemName = i.ItemName });
                    }
                    break;
                default:
                    break;
            }
            LBX_Choices.DataSource = tempItems;
        }

        //LIST CHOICES
        private void LBX_Choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var asd = LBX_Choices.SelectedItem as Items;
            if (asd != null)
            {
                L_Title.Text = asd.ItemName;
                L_Description.Text = asd.ItemDesc;
            }
        }
    }
}
