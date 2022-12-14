using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using bank_desktop_application.BL;
namespace bank_desktop_application.DL
{
    class Acc_holder_DL
    {
        private static List<Account_holder> accounts_list = new List<Account_holder>();
    
        public int chect_sort = 0;
        public static  void int_swap(int a,int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        } 
        public static void string_swap(string a,string b)
        {
            string c;
            c = a;
            a = b;
            b = c;
        }
        public static int findMinimum(int start, int end, List<Account_holder> temp_list)
        {
            int min = temp_list[start].ID1;
            int minIndex = start;
            for (int x = start; x < end; x++)
            {
                if (min > temp_list[x].ID1)
                {
                    min = temp_list[x].ID1;
                    minIndex = x;
                }
            }
            return minIndex;
        }
        internal static List<Account_holder> Accounts_list { get => accounts_list; set => accounts_list = value; }
     public static   void radixSort(List<Account_holder> temp_list)
        {
            int max = temp_list[0].ID1;
            foreach (Account_holder acc in temp_list)
            {
                if (acc.ID1 > max)
                {
                    max = acc.ID1;
                }
            }
            int place = 1;
            while ((max / place) > 0)
            {
                Radix_countingSort(temp_list, place);
                place = place * 10;
            }
        }
   public static   void Radix_countingSort(List<Account_holder> temp_list, int place)
        {
            int size = temp_list.Count();
            List<Account_holder> output = new List<Account_holder>();
            List<int> count = new List<int>(10);
            for (int x = 0; x < size; x++)
            {
                output.Add(null);
            }
            for (int x = 0; x < 10; x++)
            {
                count.Add(0); 
            }
          
            for (int x = 0; x < temp_list.Count; x++)
            {
                count[((temp_list[x].ID1/place)%10)]++;
            }
            for (int x = 1; x < 10; x++)
            {
                count[x] = count[x - 1] + count[x];
            }
            for (int x = temp_list.Count - 1; x >= 0; x--)
            {
                output[count[(temp_list[x].ID1 / place)%10] - 1] = temp_list[x];

                count[(temp_list[x].ID1 / place)%10]--;
            }
            for (int x = 0; x < output.Count; x++)
            {
                temp_list[x] = output[x];
            }

        }
        public static List<Account_holder> countingSorted(List<Account_holder> temp_list)
        {

            int size = temp_list.Count();
            int max = temp_list[0].ID1;
            foreach (Account_holder acc in temp_list)
            {
                if (acc.ID1 > max)
                {
                    max = acc.ID1;
                }
            }
            List<Account_holder> output = new List<Account_holder>();
            List<int> count = new List<int>();
            for (int x = 0; x < size; x++)
            {
                output.Add(null);
            }
            for (int x = 0; x <= max + 1; x++)
            {
                count.Add(0);
            }
            for (int x = 0; x < size; x++)
            {
                count[temp_list[x].ID1]++;
            }
            for (int x = 1; x <= max; x++)
            {
                count[x] = count[x - 1] + count[x];
            }
            for (int x = size - 1; x >= 0; x--)
            {
                output[count[temp_list[x].ID1] - 1] = temp_list[x];
                count[temp_list[x].ID1]--;
            }

            return output;

        }
        public static void storeaccountantIntoFile(Account_holder user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.Accounter_name + "," + user.Father_name + "," + user.Cnic_no + "," + user.Nationality + "," + user.Address+","+user.ID1+"," + user.Source_income );
            file.Flush();
            file.Close();
}
        
        public static void merge_Sort(List<Account_holder> temp_list, int start, int end)
        {  

            if (start < end)
            {
                int mid = (start + end) / 2;
                merge_Sort(temp_list, start, mid);
                merge_Sort(temp_list, mid + 1, end);
                merge(temp_list, start, mid, end);
            }
        }
        public static void merge(List<Account_holder> temp_list, int start, int mid, int end)
        {
         List<Account_holder> merge_list = new List<Account_holder>();

        int i = start;
            int j = mid + 1;
            while (i <= mid && j <= end)
            {
                if (temp_list[i].ID1 < temp_list[j].ID1)
                {
                    merge_list.Add(temp_list[i]);
                    i++;
                }
                else
                {
                    merge_list.Add(temp_list[j]);
                    j++;
                }
            }
            while (i <= mid)
            {
                merge_list.Add(temp_list[i]);
                i++;
            }
            while (j <= end)
            {
                merge_list.Add(temp_list[j]);
                j++;
            }
            int a = 0;
            for (int x = start; x <= end; x++)
            {
                temp_list[x] = merge_list[a];
                a++;
            }
        }
        public static void quickSort(List<Account_holder> temp_list, int start, int end)
        {
            if (start < end)
            {
                int pivot = start;
                int mid = partition(temp_list, start + 1, end, pivot);
              
                quickSort(temp_list, start, mid - 1);
                quickSort(temp_list, mid + 1, end);
            }

        }
         public static   int partition(List<Account_holder> temp_list, int start, int end, int pivot)
        {
            int left = start;
            int right = end;
            while (left <= right)
            {
                while (temp_list[left].ID1 < temp_list[pivot].ID1 && left <= end)
                    left++;
                while (temp_list[right].ID1 >= temp_list[pivot].ID1 && right >= start)
                    right--;
                if (left < right)
                {
                    Account_holder temporary = temp_list[left];
                    temp_list[left] = temp_list[right];
                    temp_list[right] = temporary;
              
                }
                  
            }
            Account_holder temp = temp_list[right];
            temp_list[right] = temp_list[pivot];
            temp_list[pivot] = temp;

            return right;
        }
        public static List<Account_holder> selection_sort()
        {
            List<Account_holder> temp_list = new List<Account_holder>();

            temp_list = Accounts_list;


            for (int x = 0; x < temp_list.Count - 1; x++)
                {
                    int minIndex = findMinimum(x, temp_list.Count, temp_list);
               
                Account_holder temp = temp_list[minIndex];
                temp_list[minIndex] = temp_list[x];
                temp_list[x] = temp;
            }
            return temp_list;
            }
        

        public static List<Account_holder> INSERTION_SORT()
        {

            List<Account_holder> temp_list = new List<Account_holder>();

            temp_list = Accounts_list;

            for (int x = 1; x < temp_list.Count; x++)
                {
                    int key = temp_list[x].ID1;
                    int y = x - 1;
                    while (y >= 0 && temp_list[y].ID1 > key)
                    {
                    Account_holder temp = temp_list[y];
                    temp_list[y] = temp_list[y + 1];
                    temp_list[y + 1] = temp;

                   
                    y--;
                    }
                    temp_list[y + 1].ID1 = key;
                }
            return temp_list;

        }
        public static List<Account_holder> BUBBLE_SORT(List<Account_holder> temp)
        {
            List<Account_holder> temp_list = new List<Account_holder>();

            temp_list = temp;

            for (int x = 0; x < temp_list.Count - 1; x++)
            {
                for (int y = 0; y < temp_list.Count - x - 1; y++)
                {
                    if (temp_list[y].ID1 > temp_list[y + 1].ID1)
                    {


                        Account_holder a = temp_list[y];
                        temp_list[y] = temp_list[y + 1];
                        temp_list[y + 1] = a;

                    }
                }
            }
            return temp_list;

        }    
        public static List<Account_holder> BUCK_INNER_SORT(List<Account_holder> temp)
        {
            

            
            for (int x = 0; x < temp.Count - 1; x++)
            {
                for (int y = 0; y < temp.Count - x - 1; y++)
                {
                    if (temp[y].ID1 > temp[y + 1].ID1)
                    {


                        Account_holder a = temp[y];
                        temp[y] = temp[y + 1];
                        temp[y + 1] = a;

                    }
                }
            }
            return temp;

        }

        public static int findMaximium(List<Account_holder> arr)
        {
            double min = arr[0].ID1;
            int minIndex = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (min < arr[i].ID1)
                {
                    min = arr[i].ID1;

                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static List<Account_holder> bucket_sort()
        {
            List<Account_holder> ARRAY = new List<Account_holder>();
            List<Account_holder> sortedList = new List<Account_holder>();
            ARRAY = accounts_list;
            var minValue = ARRAY[0].ID1;
            var maxValue = ARRAY[0].ID1;
/*
            if (array == null || array.Length <= 1)
            {
                return array;
            }*/

            for (int i = 1; i < ARRAY.Count; i++)
            {
                if (ARRAY[i].ID1 > maxValue)
                    maxValue = ARRAY[i].ID1;
                if (ARRAY[i].ID1 < minValue)
                    minValue = ARRAY[i].ID1;
            }

            var numberOfBuckets = maxValue - minValue + 1;
            List<Account_holder>[] bucket = new List<Account_holder>[numberOfBuckets];

            for (int i = 0; i < numberOfBuckets; i++)
            {
                bucket[i] = new List<Account_holder>();
            }

            for (int i = 0; i < ARRAY.Count; i++)
            {
                var selectedBucket = (ARRAY[i].ID1 / numberOfBuckets);
                bucket[selectedBucket].Add(ARRAY[i]);
            }

            for (int i = 0; i < numberOfBuckets; i++)
            {
                List<Account_holder> temp ;
                    temp= BUCK_INNER_SORT(bucket[i]);
                sortedList.AddRange(temp);
                temp = null;
            }
            return sortedList;
          
        }
     public static   void heapify(List<Account_holder> heapArr, int size, int index)
        {
            int maxIndex;
            while (true)
            {
                int lIdx = leftChildIndex(index);
                int rIdx = rightChildIndex(index);
                if (rIdx >= size)
                {
                    if (lIdx >= size)
                        return;
                    else
                        maxIndex = lIdx;
                }
                else
                {
                    if (heapArr[lIdx].ID1 >= heapArr[rIdx].ID1)
                        maxIndex = lIdx;
                    else
                        maxIndex = rIdx;
                }
                if (heapArr[index].ID1 < heapArr[maxIndex].ID1)
                {
                    Account_holder t = heapArr[index];
                    heapArr[index] = heapArr[maxIndex];
                    heapArr[maxIndex] = t;
                    index = maxIndex;
                }
                else
                    return;
            }
        }
        public static int parentIndex(int i)
        {
            return (i - 1) / 2;
        }
        public static int leftChildIndex(int i)
        {
            return (2 * i) + 1;
        }
        public static int rightChildIndex(int i)
        {
            return (2 * i) + 2;
        }
     public static   void heapSort(List<Account_holder> heapArr, int size)
        {
            for (int x = (size / 2) - 1; x >= 0; x--)
            {
                heapify(heapArr, size, x);
            }
            for (int x = size - 1; x > 0; x--)
            {
                Account_holder t = heapArr[0];
                heapArr[0] = heapArr[x];
                heapArr[x] = t;
                heapify(heapArr, x, 0);
            }
        }



    }
}
