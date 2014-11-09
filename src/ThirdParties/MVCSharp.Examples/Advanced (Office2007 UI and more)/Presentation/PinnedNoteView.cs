using Customization.ApplicationLogic;

namespace Customization.Presentation
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

