using System;

namespace PetrovLavWpf19.Models
{
	/// <summary>
	/// вспомогательный класс для вычисления длины окружности
	/// </summary>
	public static class Utils
	{
		public static double CalcCircleLength(double radius) => 2 * Math.PI * radius;
	}
}
