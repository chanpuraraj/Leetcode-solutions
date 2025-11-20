public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || s.Length <= numRows) return s;

        var rows = new StringBuilder[numRows];
        for(var i = 0; i< numRows; i++){
            rows[i] = new StringBuilder();
        }
     
        var currRow = 0;
        var goingDown = false;

        foreach(var c in s){
            rows[currRow].Append(c);

            if(currRow==0){        
                goingDown = true;
            }

            if(currRow == numRows-1){
                goingDown = false;
            }

            currRow+=goingDown?1:-1;
        }

        var result = new StringBuilder();
        foreach(var row in rows){
            result.Append(row);
        }

        return result.ToString();
    }