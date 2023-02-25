using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using WalimuCareApp.Models;

namespace WalimuCareApp.ViewModels
{
	public class FaqsViewModel : ObservableCollection<JobClassModel>, INotifyPropertyChanged
	{
		private bool _expanded;
		public string Title { get; set; }
		public string ShortName { get; set; }

		public bool Expanded
		{
			get { return _expanded; }
			set
			{
				if (_expanded != value)
				{
					_expanded = value;

					OnPropertyChanged("Expanded");

					OnPropertyChanged("StateIcon");
				}

			}
		}

		public string StateIcon
		{
			get { return Expanded ? "expand_iCon.png" : "collapsed_icon.png"; }
		}
		public int JobItems { get; set; }

		public FaqsViewModel(string title, bool expanded = false)
		{
			Title = title;

			Expanded = expanded;
		}

		public static ObservableCollection<FaqsViewModel> Contents { private set; get; }
		static FaqsViewModel()
		{
			ObservableCollection<FaqsViewModel> Items = new ObservableCollection<FaqsViewModel>
			{
				new FaqsViewModel("Description")
				{
					new JobClassModel{Description= "Tegla Chepkite Loroupe is a Kenyan long-distance track and road runner. She is also a global spokeswoman for peace, women's rights and education. Loroupe holds the world records for 25 and 30 kilometers and previously held the world marathon",}
				},
				new FaqsViewModel("Background")
				{
					new JobClassModel{Description= "Tegla Chepkite Loroupe is a Kenyan long-distance track and road runner. She is also a global spokeswoman for peace, women's rights and education. Loroupe holds the world records for 25 and 30 kilometers and previously held the world marathon",}
				},
				new FaqsViewModel("Experience")
				{
					new JobClassModel{Description= "Tegla Chepkite Loroupe is a Kenyan long-distance track and road runner. She is also a global spokeswoman for peace, women's rights and education. Loroupe holds the world records for 25 and 30 kilometers and previously held the world marathon",}
				},
				new FaqsViewModel("Education")
				{
					new JobClassModel{Description= "Tegla Chepkite Loroupe is a Kenyan long-distance track and road runner. She is also a global spokeswoman for peace, women's rights and education. Loroupe holds the world records for 25 and 30 kilometers and previously held the world marathon",}
				},
			};
			Contents = Items;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
