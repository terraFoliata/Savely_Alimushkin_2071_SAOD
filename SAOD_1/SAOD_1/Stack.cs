using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class Stack<T>
{
	public int cur;
	public T[] arr;
	public Stack(int size)
	{
		arr = new T[size];
		cur = 0;
	}
	public void Push(T val)
	{
		try
		{
			arr[cur] = val;
			cur++;
		}
		catch (Exception)
		{
		}

	}
	public T Pop()
	{
		cur--;
		ToArray();
		return (arr[cur]);
	}
	public T Top()
	{
		return (arr[cur - 1]);
	}
	public bool IsEmpty()
	{

		return true;
	}
	public T[] ToArray()
	{
		T[] mas = new T[cur];
		for (int i = 0; i <= cur - 1; i++)
		{
			mas[i] = arr[i];
		}
		return mas;
	}
}
