using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reshotka
{
    public partial class AddWords : Form
    {
        
        public AddWords()
        {
            InitializeComponent();
        }


        // добавление слова
        private void addWordBtn_Click(object sender, EventArgs e)
        {
            if (wordTb.Text != "" && helpTb.Text != "")
            {
                wordsPanel.Rows.Add(wordTb.Text.ToLower(), helpTb.Text);

                wordTb.Text = "";
                helpTb.Text = "";
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }


        // нажатие на создание кроссворда
        private void createCross_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "")
            {
                MessageBox.Show("Введите имя кроссворда!");
            }
            else if (wordsPanel.Rows.Count < 3)
            {
                MessageBox.Show("Добавьте не менее 2-x слов!");
            }
            else
            {

                Form1 form1 = new Form1();
                // создаём новый кроссворд
                CrossItem cross = new CrossItem(nameTb.Text);


                // пробегаемся по всем элементам таблицы и берём слова
                for (int i = 0; i < wordsPanel.Rows.Count - 1; i++) 
                {
                    for (int j = 0; j < wordsPanel.Columns.Count - 1; j++) 
                    {
                        // создаём слово и добавляем его в кроссворд
                        WordItem word = new WordItem(i+1, wordsPanel[j, i].Value.ToString().ToLower(), wordsPanel[j+1, i].Value.ToString());
                        cross.AddWord(word);
                    }
                    
                }

                form1.AddCrossword(cross);
                MessageBox.Show("Кроссворд успешно создан!");
                Dispose();
            }
        }

        private void AddWords_Load(object sender, EventArgs e)
        {
            //Пусто
        }
    }
}
