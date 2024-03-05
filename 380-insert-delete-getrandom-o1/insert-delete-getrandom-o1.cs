public class RandomizedSet {
    private List<int> list;
    private Dictionary<int,int> map;
    private Random random;

    public RandomizedSet() {
        list = new List<int>();
        map = new Dictionary<int,int>();
        random = new Random();
    }
    
    public bool Insert(int val) {
        if (!map.ContainsKey(val)) {
            list.Add(val);
            map[val] = list.Count - 1;
            //Console.WriteLine($"Insert({val}) list -> {String.Join(',', list.ToArray())}");
            return true;
        }
        return false;        
    }
    
    public bool Remove(int val) {
        if (map.ContainsKey(val)) {
            list.Remove(val);            
            map.Remove(val);
            //Console.WriteLine($"Remove({val}) list -> {String.Join(',', list.ToArray())}");
            return true;
        }
        return false;
    }
        
    public int GetRandom() { 
        //Console.WriteLine($"GetRandom() for list[{list.Count}]");
        return list[random.Next(list.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */