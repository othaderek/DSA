using System;

class ArrayOperations {
  public int[] Reverse(int[] arr)
    {
      int i;
      int temp;
      int length = arr.Length;
      for (i = 0; i < length/2; i++){
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
      for (i = 0; i < arr.Length; i++){
        str += arr[i].ToString();
      }
      return str;
    }

    public int[] InsertAt(int[] arr, int num){

      return arr;
    }

    public int[] InsertBefore(int[] arr, int num){

      return arr;
    }

    public int[] InsertAfter(int[] arr, int num){

      return arr;
    }

    public int[] LinearSearch(int[] arr, int num){

      return arr;
    }

    public int[] RotateAtK(int[] arr, int k){

      return arr;
    }
    
}
