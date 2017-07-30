using System;
using System.Windows.Forms;

namespace Woodrow
{
    public partial class InputForm : Form
    {
        public int MigrationNumber => (int) numMigration.Value;
        public string TeamName => txtTeam.Text;

        public InputForm()
        {
            InitializeComponent();
        }

        public void SetState(int migrationNumber, string teamName)
        {
            numMigration.Value = migrationNumber;
            txtTeam.Text = teamName;
        }

    }
}
