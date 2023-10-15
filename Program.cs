using System;
using System.Collections.Generic;

class Program
{  

 
     static void Main()
    {
      MergeList mergeList = new MergeList();
       List<int> list1 =  new List<int> {1,2,4,9};
       List<int> list2 =  new List<int> {1,4,10};
       ListNode NList1 = mergeList.ConvertToLinkedList(list1);
       ListNode NList2 = mergeList.ConvertToLinkedList(list2);
       mergeList.MergeTwoSortedList(NList1 ,NList2);
    }

   
}
