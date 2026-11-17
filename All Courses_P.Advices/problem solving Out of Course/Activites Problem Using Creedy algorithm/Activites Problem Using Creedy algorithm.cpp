#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

// A structure to represent an activity
struct Activity {
    int start, finish;
};

// Comparison function to sort activities by their finish time
bool compare(Activity a, Activity b) {
    return a.finish < b.finish;
}

// Function to select the maximum number of activities
void activitySelection(vector<Activity>& activities) {
    // Step 1: Sort the activities by finish time
    sort(activities.begin(), activities.end(), compare);

    cout << "Selected activities: " << endl;

    // Step 2: Select the first activity
    int lastFinishTime = activities[0].finish;
    cout << "(" << activities[0].start << ", " << activities[0].finish << ")" << endl;

    // Step 3: Iterate through the remaining activities
    for (size_t i = 1; i < activities.size(); i++) {
        // If the start time is greater than or equal to the last finish time
        if (activities[i].start >= lastFinishTime) {
            // Select the activity
            cout << "(" << activities[i].start << ", " << activities[i].finish << ")" << endl;
            lastFinishTime = activities[i].finish; // Update the last finish time
        }
    }
}

int main() {
    // Input: List of activities with start and finish times
    vector<Activity> activities = {
        {1, 2}, {3, 4}, {0, 6}, {5, 7}, {8, 9}, {5, 9}
    };

    // Output the maximum number of activities
    activitySelection(activities);

    return 0;
}