#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int GetMaxMeetings(int n, vector<int>& start, vector<int>& end) {
    vector<pair<int, int>> intervals(n);

    for (int i = 0; i < n; i++) {
        intervals[i] = { start[i], end[i] };
    }

    // Sorting by end time to maximize meetings
    sort(intervals.begin(), intervals.end(), [](const pair<int, int>& a, const pair<int, int>& b) {
        return a.second < b.second;
        });

    int ans = 0;
    int lastEnd = 0;

    for (const pair<int, int>& interval : intervals) { // Explicit type

        int starting = interval.first;
        int ending = interval.second;

        if (starting >= lastEnd) {
            ans++;
            lastEnd = ending;
        }
    }

    return ans;
}

int main() {
    vector<int> start = { 1, 3, 0, 5, 5, 8 };
    vector<int> end = { 2, 4, 6, 7, 9, 9 };
    int n = start.size();

    cout << "Maximum number of meetings: " << GetMaxMeetings(n, start, end) << endl;

    return 0;
}
