class BinarySearch { 
 
    int binarySearch(int arr[], int x) { 
        int l = 0, r = arr.length - 1; 
        while (l <= r) { 
            int m = l + (r - l) / 2; 
  
            //x değeri ortanca değer mi kontrol et
            if (arr[m] == x) 
                return m; 
  
            // x ortanca değerden büyükse, sol yarıyı görmezden gelir
            if (arr[m] < x) 
                l = m + 1; 
  
            // x ortanca değerden küçükse, sağ yarıyı görmezden gelir
            else
                r = m - 1; 
        } 
  
        // x değeri dizide bulunamadıysa -1 değerini döner
        return -1; 
    } 
  
    public static void main(String args[]) { 
        BinarySearch search = new BinarySearch(); 
        int arr[] = { 1, 3, 5, 7, 9 }; 
        int n = arr.length; 
        int x = 7; 
        int result = search.binarySearch(arr, x); 
        if (result == -1) 
            System.out.println("Element not present"); 
        else
            System.out.println("Element found at "
                               + "index " + result); 
    } 
} 