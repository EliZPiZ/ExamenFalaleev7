using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;



namespace EkzFalaleevBilet7
{
    public partial class Theatre : Form
    {
        double Price = 0;
        int QuantityDiscount = 0;
        double TotalDiscount = 0;

        double StartingPrice = 1000;
        int VIPPrice = 50;
        int PartherPrice = 7;
        int BalconyPrice = 20;

        string PicturePath = System.IO.Directory.GetCurrentDirectory();

        string PictureName = string.Empty;

        Word._Application oWord = new Word.Application();

        public Theatre()
        {
            InitializeComponent();
        }

        private void Theatre_Load(object sender, EventArgs e)
        {

        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SceneSelector.Text)) // Проверяем выбрано ли желаемое представление
            {
                if (VIPRButton.Checked || PartherRButton.Checked || BalconyRButton.Checked) // Проверяем выбран ли тип билета
                {
                    if (QuantityBox.Text != String.Empty || QuantityBox.Text != "") // Проверяем выбрано ли количество билетов
                    {
                        GetQuantityDiscount();

                        if (VIPRButton.Checked)
                        {
                            Price = ((StartingPrice + (StartingPrice * VIPPrice) / 100)) * Convert.ToDouble(QuantityBox.Text);
                            GetPriceDiscount();
                            Price = Price - TotalDiscount;
                        }
                        else if (PartherRButton.Checked)
                        {
                            Price = ((StartingPrice + (StartingPrice * PartherPrice) / 100)) * Convert.ToDouble(QuantityBox.Text);
                            GetPriceDiscount();
                            Price = Price - TotalDiscount;
                        }
                        else
                        {
                            Price = ((StartingPrice + (StartingPrice * BalconyPrice) / 100)) * Convert.ToDouble(QuantityBox.Text);
                            GetPriceDiscount();
                            Price = Price - TotalDiscount;
                        }

                        PriceLabel.Text = $@"Общая стоимость билетов будет: {Price} рублей.";

                        PictureName = SceneSelector.Text;
                        try
                        {
                            pictureBox1.Image = Image.FromFile(PicturePath + @"\" + PictureName + ".png");

                        }
                        catch
                        {
                            MessageBox.Show("Не удалось загрузить изображение!", "Ошибка");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, укажите необходимое количество билетов!", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите тип билета!", "Ошибка!");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите представление!", "Ошибка!");
            }
        }

        private void QuantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
        private int GetQuantityDiscount()
        {
            if (Convert.ToDouble(QuantityBox.Text) > 30)
            {
                QuantityDiscount = 25;
            }
            else if (Convert.ToDouble(QuantityBox.Text) > 20)
            {
                QuantityDiscount = 10;
            }
            else if (Convert.ToDouble(QuantityBox.Text) > 15)
            {
                QuantityDiscount = 7;
            }
            else if (Convert.ToDouble(QuantityBox.Text) > 10)
            {
                QuantityDiscount = 5;
            }

            return QuantityDiscount;
        }

        private double GetPriceDiscount()
        {
            if (QuantityDiscount > 0)
            {
                TotalDiscount = (Price * QuantityDiscount) / 100;
            }
            return TotalDiscount;
        }
        private void Write() //Вызов функции записи в шаблон
        {
            _Document oDoc = GetDoc(Environment.CurrentDirectory + "\\чек.dotx");
            oDoc.SaveAs(FileName: Environment.CurrentDirectory + "\\ЧекВыход.docx");
            oDoc.Close();
        }
        private _Document GetDoc(string path) //Выбор документа
        {
            _Document oDoc = oWord.Documents.Add(path);
            SetTemplate(oDoc);
            return oDoc;
        }

        private void SetTemplate(Word._Document oDoc) //Запись в файл
        {
            oDoc.Bookmarks["ID"].Range.Text = (DateTime.Now.ToString().Replace(".", "").Replace(":", "") + Price).Trim();
            oDoc.Bookmarks["Date"].Range.Text = DateTime.Now.ToString();
            oDoc.Bookmarks["Product"].Range.Text = SceneSelector.Text;
            oDoc.Bookmarks["Price"].Range.Text = Price.ToString() + " руб.";
        }

        private void MakeReceiptButton_Click(object sender, EventArgs e)
        {
            Write();
            MessageBox.Show("Чек был успешно создан!", "Уведомление");
        }
    }
}
