namespace GenericsTask.Models;

internal class List<T>
{
    T[] _arr=new T[0];
    public int Capacity { get; set; } 
    public int Count { get; set; }=0;
    public List()
    {
        
    }
    public List(int capacity)
    {
        Capacity = capacity <= 0? 10: capacity;
    }
    public List(int capacity,params T[] array)
    {
        _arr = array;
        
        Count = array.Length;
        
    }


    public void Add(T array)
    {
        if (Count == _arr.Length)
        {
            Array.Resize(ref _arr, Count + Capacity);

        }
        _arr[Count++] = array;
       
    }

    public void Remove(T[] array, int index)
    {
        for (int i = index; i < _arr.Length - 1; i++)
        {
            _arr[i] = _arr[i + 1];
        }
        Array.Resize(ref _arr, Count - 1);

    }

    public void Reverse()
    {

    }
    public void IndexOf(T[] arr,int searchNums)
    {
        int index = Array.IndexOf(arr, searchNums);
        if (index > 0 )
        {
            Console.WriteLine("number: "+searchNums+"index"+arr);
        }
        else
        {
            Console.WriteLine("Bele bir element tapilmadi");
        }
        
        

    }

    public void LastIndexOf(T[] array,int nums)
    {
        int index=Array.LastIndexOf(array,nums);
        if(index > 0)
        {
            Console.WriteLine(array);
        }
        else
        {

            Console.WriteLine("Bele bir element tapilmadi");
        }
       
    }

    public void Clear(T[] array)
    {
        

    }
    //public bool Exits(int arr)
    //{
        

    //}
}
