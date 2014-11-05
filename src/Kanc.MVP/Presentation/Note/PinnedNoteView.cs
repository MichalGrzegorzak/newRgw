using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;

namespace Kanc.MVP.Presentation.Note
{
    [ViewEx(typeof(MainTask), MainTask.PinnedNote, "Post")]
    public partial class PinnedNoteView : NoteView
    {
        public PinnedNoteView()
        {
            InitializeComponent();
        }
    }
}

