using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudyEnglish
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<string> wordsEn;
		List<string> wordsRu;
		
		Random rnd = new Random();
		
		int currentIndex = 0;
        int correctAnswers = 0;
        int wrongAnswers = 0;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
			wordsEn = File.ReadAllLines("e.txt").ToList();
            wordsRu = File.ReadAllLines("r.txt").ToList();
            
            var order = Enumerable.Range(0, wordsEn.Count).OrderBy(x => rnd.Next()).ToList();
            wordsEn = order.Select(i => wordsEn[i]).ToList();
            wordsRu = order.Select(i => wordsRu[i]).ToList();

            ShowNextWord();
	
		}
		void ShowNextWord()
        {
            if (currentIndex >= wordsRu.Count)
            {
                label1.Text = "Words ended!";
                return;
            }

            label1.Text = wordsRu[currentIndex];

            var options = new List<string>();
            options.Add(wordsEn[currentIndex]);

            while (options.Count < 4)
            {
                int idx = rnd.Next(wordsEn.Count);
                if (idx != currentIndex && !options.Contains(wordsEn[idx]))
                    options.Add(wordsEn[idx]);
            }

            options = options.OrderBy(x => rnd.Next()).ToList();

            button1.Text = options[0];
            button2.Text = options[1];
            button3.Text = options[2];
            button4.Text = options[3];

            label2.Text = "Good: " + correctAnswers;
            label3.Text = "Bad: " + wrongAnswers;
        }
		void CheckAnswer(object sender, EventArgs e)
		{
		    Button btn = sender as Button;
		    if (btn.Text == wordsEn[currentIndex])
		        correctAnswers++;
		    else
		        wrongAnswers++;
		
		    currentIndex++;
		
		    if (currentIndex < wordsRu.Count){
		    	ShowNextWord();
		    }
		    else {
		    	label1.Text = "Words Ended!";
		    	button1.Enabled = false;
		    	button2.Enabled = false;
		    	button3.Enabled = false;
		    	button4.Enabled = false;
		    }
		}
		void MainFormShown(object sender, EventArgs e)
		{
			button1.Click += CheckAnswer;
    		button2.Click += CheckAnswer;
    		button3.Click += CheckAnswer;
    		button4.Click += CheckAnswer;
		}
	}
}
