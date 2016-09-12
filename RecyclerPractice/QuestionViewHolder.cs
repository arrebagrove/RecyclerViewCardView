using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace RecyclerPractice
{
    public class QuestionViewHolder : RecyclerView.ViewHolder
    {
        public TextView QuestionDescription { get; set; }
        public Button AnswerBtn { get; set; }

        public QuestionViewHolder(View itemView) : base(itemView)
        {
            QuestionDescription = itemView.FindViewById<TextView>(Resource.Id.textView1);
            AnswerBtn = itemView.FindViewById<Button>(Resource.Id.button1);
        }
    }
}