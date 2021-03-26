using System;

namespace DSA
{
  class ArrayOperations {
    public int[] Reverse(int[] arr)
    {
      int i;
      int temp;
      int length = arr.Length;
      for (i = 0; i < length/2; i++)
      {
        temp = arr[length-1-i];
        arr[length-1-i] = arr[i];
        arr[i] = temp;
      }
      return arr;
    }

    public string PrintArray(int[] arr)
    {
      int i;
      string str = "";
      for (i = 0; i < arr.Length; i++)
      {
        str += arr[i].ToString();
      }
      return str;
    }

    public int[] InsertAt(int[] arr, int index, int num)
    {
      arr[index] = num;
      return arr;
    }

    public int[] InsertBefore(int[] arr, int index, int num)
    {
      int length = arr.Length;
      int i;
      int[] newArr = new int[length+1];

      for (i = 0; i < length; i++)
      {
        //
        if (i == index-1)
        {
          newArr[i] = num;
        } else if (i >= index)
        {
          newArr[i] = arr[i-1]; // starting at index 3 set one index behind of old array
          newArr[i+1] = arr[i]; // then set one index ahead on new array to current index of old array
        } else 
        {
          newArr[i] = arr[i];
        }
      }
      return newArr;
    }

    public int[] InsertAfter(int[] arr, int num)
    {

      return arr;
    }

    public int LinearSearch(int[] arr, int num)
    {
      int length = arr.Length;
      int i;
		
      for (i = 0; i < length; i++)
      {
        if (arr[i] == num)
        {
          return i;
        }
      }
      return -1;
    }

    public int[] RotateAtK(int[] arr, int k)
    {

      return arr;
    }

  }
}
