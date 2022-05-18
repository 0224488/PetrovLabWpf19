using PetrovLavWpf19.Models;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PetrovLavWpf19.ViewModels
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		public MainWindowViewModel()
		{
			CircleLengthCommand = new RelayCommand(OnCircleLengthCommandExecute, CanCircleLengthCommandExecuted);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private int _radius;
		// Радиус окружности
		public int Radius
		{
			get { return _radius; }
			set { _radius = value; OnPropertyChanged(); }
		}

		// длина окружности
		private double _length;
		public double Length
		{
			get { return _length; }
			set { _length = value; OnPropertyChanged(); }
		}

		// команда вычисления длины окружности
		public ICommand CircleLengthCommand { get; }

		// вычисление длины окружности
		private void OnCircleLengthCommandExecute(object r)
		{
			Length = Utils.CalcCircleLength(Radius);
		}

		private bool CanCircleLengthCommandExecuted(object r)
		{
			if(Radius != 0)
				return true;
			return false;
		}

		private void OnPropertyChanged([CallerMemberName] string PropertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
		}
	}
}
