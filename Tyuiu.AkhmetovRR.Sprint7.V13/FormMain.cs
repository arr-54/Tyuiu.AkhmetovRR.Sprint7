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

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_���������_Click(object sender, EventArgs e)
        {
            string strana = ��������������_���������.Text;
            string stolitsa = �������_���������.Text;
            string ploschad = �����������������_���������.Text;
            string razvitalistrana = ���������������_���������.Text;
            string naselenie = �������������������_���������.Text;
            string natsionalnost = ��������������_���������.Text;
            string primechanie = ����������_���������.Text;
            using (StreamWriter writer = new StreamWriter(path, append: true, encoding: Encoding.UTF8))
            {
                writer.WriteLine(string.Join(";", new string[] { strana, stolitsa, ploschad, razvitalistrana, naselenie, natsionalnost, primechanie }));
            }
            ��������������_���������.Clear();
            �������_���������.Clear();
            �����������������_���������.Clear();
            ���������������_���������.Clear();
            �������������������_���������.Clear();
            ��������������_���������.Clear();
            ����������_���������.Clear();
            MessageBox.Show("������ ���������");
        }

        private void btnSave_���������_Click(object sender, EventArgs e)
        {
            path = DataService.SelectFile(path, �����������_���������.Text);
            gBoxInput_���������.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnOutPut_���������_Click(object sender, EventArgs e)
        {
            dGv_���������.Rows.Clear();
            dGv_���������.Columns.Clear();
            var lines = File.ReadAllLines(path, encoding: Encoding.UTF8);
            if (lines.Length > 0)
            {
                string[] headers = lines[0].Split(';');

                foreach (var header in headers)
                {
                    dGv_���������.Columns.Add(header, header);
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] row = lines[i].Split(";");
                    dGv_���������.Rows.Add(row);
                }
            }
        }

        private void btnRemove_���������_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGv_���������.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    string rowdata = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString()));
                    dGv_���������.Rows.Remove(row);
                    MessageBox.Show("������ �������");
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

        private void �����������_���������_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
