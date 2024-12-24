using System.Text;
using Tyuiu.AkhmetovRR.Sprint7.V13.Lib;

namespace Tyuiu.AkhmetovRR.Sprint7.V13
{
    public partial class FormMain : Form
    {
        private string path = "data.csv";
        public string GetPath()
        {
            return path;
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_АхметовРР_Click(object sender, EventArgs e)
        {
            string strana = Названиестраны_АхметовРР.Text;
            string stolitsa = Столица_АхметовРР.Text;
            string ploschad = Площадьтерритории_АхметовРР.Text;
            string razvitalistrana = Развиталистрана_АхметовРР.Text;
            string naselenie = Количествонаселения_АхметовРР.Text;
            string natsionalnost = Национальность_АхметовРР.Text;
            string primechanie = Примечание_АхметовРР.Text;
            using (StreamWriter writer = new StreamWriter(path, append: true, encoding: Encoding.UTF8))
            {
                writer.WriteLine(string.Join(";", new string[] { strana, stolitsa, ploschad, razvitalistrana, naselenie, natsionalnost, primechanie }));
            }
            Названиестраны_АхметовРР.Clear();
            Столица_АхметовРР.Clear();
            Площадьтерритории_АхметовРР.Clear();
            Развиталистрана_АхметовРР.Clear();
            Количествонаселения_АхметовРР.Clear();
            Национальность_АхметовРР.Clear();
            Примечание_АхметовРР.Clear();
            MessageBox.Show("Данные сохранены");
        }

        private void btnSave_АхметовРР_Click(object sender, EventArgs e)
        {
            path = DataService.SelectFile(path, Выбратьфайл_АхметовРР.Text);
            gBoxInput_АхметовРР.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnOutPut_АхметовРР_Click(object sender, EventArgs e)
        {
            dGv_АхметовРР.Rows.Clear();
            dGv_АхметовРР.Columns.Clear();
            var lines = File.ReadAllLines(path, encoding: Encoding.UTF8);
            if (lines.Length > 0)
            {
                string[] headers = lines[0].Split(';');

                foreach (var header in headers)
                {
                    dGv_АхметовРР.Columns.Add(header, header);
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] row = lines[i].Split(";");
                    dGv_АхметовРР.Rows.Add(row);
                }
            }
        }

        private void btnRemove_АхметовРР_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGv_АхметовРР.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    string rowdata = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString()));
                    dGv_АхметовРР.Rows.Remove(row);
                    MessageBox.Show("Строка удалена");
                    Removerow(path, rowdata);
                }
            }
        }
        private void Removerow(string path, string row)
        {
            var lines = File.ReadAllLines(path, encoding: Encoding.UTF8).ToList();
            lines.RemoveAll(line => line == row);
            File.WriteAllLines(path, lines, encoding: Encoding.UTF8);
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            Analizform form = new Analizform();
            form.Show();

        }

        private void Выбратьфайл_АхметовРР_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
