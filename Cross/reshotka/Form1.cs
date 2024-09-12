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
    public partial class Form1 : Form
    {
        int X = 10;  // Координаты для начала кроссворда
        int Y = 5;
        int ID = 1;
        bool isWrite = false;
        // сохранённые кроссворды
        static List<CrossItem> crosswords = new List<CrossItem>();
        // уже использованные слова
        List<string> blackList = new List<string>();
        // слова
        List<string> words = new List<string>() { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeBoard();
            crosswordsUpdate();
        }


        // отрисовка и выравнивание сетки
        private void InitializeBoard()
        {
            board.BackgroundColor = Color.Black;
            board.DefaultCellStyle.BackColor = Color.Black;
            board.DefaultCellStyle.SelectionBackColor = Color.DarkGray;

            if (board.Rows.Count == 0)
            {
                for (int i = 0; i < 21; i++)
                {
                    board.Rows.Add();
                }

                foreach (DataGridViewColumn c in board.Columns)
                {
                    c.Width = board.Width / board.Columns.Count;
                }

                foreach (DataGridViewRow r in board.Rows)
                {
                    r.Height = board.Height / board.Rows.Count;
                }

                for (int row = 0; row < board.Rows.Count; row++)
                {
                    for (int col = 0; col < board.Columns.Count; col++)
                    {
                        board[col, row].Value = " ";
                        board[col, row].ReadOnly = true;

                    }
                }
            }
        }


        // обновление списка кроссвордов
        private void crosswordsUpdate()
        {
            crosswordsCb.Items.Clear();
            foreach (CrossItem item in crosswords)
            {
                crosswordsCb.Items.Add(item.name);
            }
        }


        // начало игры
        private void StartGame(CrossItem cross)
        {
            // очищение всего
            ID = 1;
            blackList.Clear();
            words.Clear();
            board.CellValueChanged -= Board_CellValueChanged;
            board.Rows.Clear();
            helpPanel.Rows.Clear();
            InitializeBoard();


            // добавление слов в массив и подсказок
            foreach (WordItem item in cross.wordList)
            {
                words.Add(item.word);
                helpPanel.Rows.Add(item.ID, item.help);
            }

            string startWord = words.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur); // нахождение наибольшего слова
            words.Remove(startWord);


            // написание макета главного слова
            for (int i = 0; i < startWord.Length; i++)
            {
                AddCymbol(Y, X, startWord[i].ToString());
                Y++;
            }

            Y = 5;


            // поиск пересечений и написание подходящих слов
            for (int i = 0; i < startWord.Length; i++)
            {
                isWrite = false;
                foreach (string w in words)
                {
                    if (isWrite)
                    {
                        break;
                    }
                    if (!blackList.Contains(w))
                    {
                        for (int j = 0; j < w.Length; j++)
                        {
                            if (w[j] == startWord[i])
                            {
                                int startX = X - j;
                                int startY = Y + i;
                                AddNumCymbol(startY, startX - 1, cross.wordList.Find(x => x.word == w).ID.ToString());
                                ID++;

                                for (int o = 0; o < w.Length; o++)
                                {
                                    AddCymbol(startY, startX, w[o].ToString());
                                    startX++;
                                }
                                isWrite = true;
                                blackList.Add(w);
                            }
                        }
                    }
                }
            }


            // повторный поиск пересечений
            for (int i = 0; i < startWord.Length; i++)
            {
                if (board[X - 1, Y + i].Value.ToString() == "" && board[X + 1, Y + i].Value.ToString() == "")
                {
                    isWrite = false;
                    foreach (string w in words)
                    {
                        if (isWrite)
                        {
                            break;
                        }
                        if (!blackList.Contains(w))
                        {
                            for (int j = 0; j < w.Length; j++)
                            {
                                if (startWord[i] == w[j])
                                {
                                    int startX = X - j;
                                    int startY = Y + i;
                                    AddNumCymbol(startY, startX - 1, ID.ToString());
                                    ID++;

                                    foreach (char c in w)
                                    {
                                        AddCymbol(startY, startX, c.ToString());
                                        startX++;
                                    }
                                    isWrite = true;
                                    blackList.Add(w);
                                }
                            }
                        }
                    }
                }
            }

            // добавление обрабтчика событий
            board.CellValueChanged += Board_CellValueChanged;
        }


        // Проверка совпадения тега с написанной пользователем буквой и закрашивание клетки в нужный цвет
        private void Board_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (board[e.ColumnIndex, e.RowIndex].Tag.ToString().ToLower() == board[e.ColumnIndex, e.RowIndex].Value.ToString().ToLower())
            {
                board[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightGreen;
            }
            else
            {
                board[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.IndianRed;
            }
        }


        // добавить кроссворд в список
        public void AddCrossword(CrossItem cross)
        {
            crosswords.Add(cross);
        }


        // добавление тега
        private void AddCymbol(int row, int col, string letter)
        {
            DataGridViewCell c = board[col, row];
            c.Style.BackColor = Color.White;
            c.ReadOnly = false;
            c.Style.SelectionBackColor = Color.Cyan;
            c.Tag = letter;
            c.Value = "";
        }


        // добавление номера слова
        private void AddNumCymbol(int row, int col, string letter)
        {
            DataGridViewCell c = board[col, row];
            c.ReadOnly = false;
            c.Style.ForeColor = Color.White;
            c.Tag = letter;
            c.Value = letter;
        }


        // Окно создания нового кроссворда
        private void addWordsBtn_Click(object sender, EventArgs e)
        {
            AddWords addWords = new AddWords();
            addWords.ShowDialog();
            crosswordsUpdate();
        }


        // нажатие кнопки начало игры
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (crosswordsCb.SelectedItem != null)
            {
                CrossItem item = crosswords.Find(c => c.name == crosswordsCb.SelectedItem.ToString());
                StartGame(item);
            }
            else
            {
                MessageBox.Show("Выберите или создайте кроссворд!");
            }

        }

        // Программу создал студент 305 группы: Таранов Сергей
        private void button1_Click_1(object sender, EventArgs e)
        {
          
            MessageBox.Show("Программу создал студент 305 группы: \n" +
               "Таранов Сергей");
          
        }
    }
}
