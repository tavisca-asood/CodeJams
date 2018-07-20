// Complete the findMax function below.
int findMax(vector<vector<int>> inputArray) {
    int sum;
    int largest_sum=INT_MIN;
    for(int loopVariable1=0;loopVariable1<inputArray.size()-2;loopVariable1++)
    {
        for(int loopVariable2=1;loopVariable2<inputArray[loopVariable1].size()-1;loopVariable2++)
        {
            sum=0;
            sum+=inputArray[loopVariable1][loopVariable2-1];
            sum+=inputArray[loopVariable1][loopVariable2];
            sum+=inputArray[loopVariable1][loopVariable2+1];
            sum+=inputArray[loopVariable1+1][loopVariable2];
            sum+=inputArray[loopVariable1+2][loopVariable2-1];
            sum+=inputArray[loopVariable1+2][loopVariable2];
            sum+=inputArray[loopVariable1+2][loopVariable2+1];
            if(sum>largest_sum)
                largest_sum=sum;
        }
    }
    return largest_sum;
}

