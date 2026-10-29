using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VodokanalDispatch
{
    static class CsvExport
    {
        public static void Save(DataGridView grid, string fileName)
        {
            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "Таблица Excel (CSV)|*.csv";
                dialog.FileName = fileName + " " + DateTime.Now.ToString("dd.MM.yyyy") + ".csv";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                var columns = grid.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).OrderBy(c => c.DisplayIndex).ToList();
                var text = new StringBuilder();
                text.AppendLine(string.Join(";", columns.Select(c => Escape(c.HeaderText))));
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow)
                        continue;
                    text.AppendLine(string.Join(";", columns.Select(c => Escape(Convert.ToString(row.Cells[c.Index].FormattedValue)))));
                }

                try
                {
                    File.WriteAllText(dialog.FileName, text.ToString(), Encoding.UTF8);
                    MessageBox.Show("Файл сохранён:\n" + dialog.FileName, "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось сохранить файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string Escape(string value)
        {
            if (value.Contains(";") || value.Contains("\"") || value.Contains("\n"))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }
    }
}
