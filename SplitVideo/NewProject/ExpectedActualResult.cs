using System.Windows.Forms;
using EmotionMarketing.Logic.DbWorker;

namespace SplitVideo.NewProject
{
    public partial class ExpectedActualResult : Form
    {
        public ExpectedActualResult(int id)
        {
            InitializeComponent();
            var worker = new ProjectWorker();
            worker.LoadResultToGrid(id, expectedGrid, actualGrid);
        }
    }
}
