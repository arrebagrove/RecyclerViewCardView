using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace RecyclerPractice
{
    public class QuestionAdapter : RecyclerView.Adapter
    {
        public List<Question> Questions { get; set; }
        public RecyclerView RecyclerView { get; set; }

        public QuestionAdapter(List<Question> questions, Activity activity)
        {
            Questions = questions;
            RecyclerView = activity.FindViewById<RecyclerView>(Resource.Id.recyclerView);
        }

        public override int ItemCount
        {
            get
            {
                return Questions.Count;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var vh = (QuestionViewHolder)holder;

            //  Fill up item info from questions list
            vh.QuestionDescription.Text = Questions[position].Description;
            vh.AnswerBtn.Click += AnswerBtn_Click;
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            //  Get item position
            var button = (Button)sender;
            int position = RecyclerView.GetChildLayoutPosition((View)button.Parent.Parent);

            //  Manage data
            Questions[position].Description = "Clickeada";

            //  Notify changes to the adapter
            NotifyDataSetChanged();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layout = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.Question, parent, false);
            return new QuestionViewHolder(layout);
        }
    }
}