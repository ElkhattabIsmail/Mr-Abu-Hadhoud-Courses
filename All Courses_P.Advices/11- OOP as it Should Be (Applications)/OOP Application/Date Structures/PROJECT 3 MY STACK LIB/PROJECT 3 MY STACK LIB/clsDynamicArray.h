#pragma once

#include <iostream>
using namespace std;

template <class T>
class clsDynamicArray
{

    
protected:
    int _Size = 0;
    T* _TempArray;

public:
    T* OriginalArray;
    
    clsDynamicArray(int Size = 0)
    {
        if (Size < 0)
            Size = 0;

        _Size = Size;

        OriginalArray = new T[_Size];

    }

    ~clsDynamicArray()
    {

        delete[]  OriginalArray;

    }

    bool SetItem(int index, T Value)
    {
        if (index >= _Size || _Size < 0)
        {
            return false;
        }

        OriginalArray[index] = Value;
        return true;

    }


    int Size()
    {
        return _Size;
    }

    bool IsEmpty()
    {
        return _Size == 0;

    }

    void PrintList()

    {
        for (int i = 0; i < _Size ; i++)
        {
            cout << OriginalArray[i] << " ";
        }

        cout << "\n";

    }
    void Resize(int NewSize)
    {

            if (NewSize < 0 || NewSize = _Size)
            {
                return;
            };

            _TempArray = new T[NewSize];

            //limit the original size to the new size if it is less.
            if (NewSize < _Size)
                _Size = NewSize;

            //copy all data from original array until the size
            for (int i = 0; i < _Size; i++)
            {
                _TempArray[i] = OriginalArray[i];
            }

            _Size = NewSize;

            delete[] OriginalArray;  //Delete All original items

            OriginalArray = _TempArray;  // get the copy items
        
    }
    T GetItem(int index)
    {
        return OriginalArray[index];
    }
    void Reverse()
    {
        _TempArray = new T[_Size];

        for (int i = 0; i < _Size; i++)
        {
            _TempArray[i] = OriginalArray[(_Size - 1) - i];
        }
        delete[] OriginalArray;  //Delete All original items

        OriginalArray = _TempArray;  // get the copy items

    }
    void Clear()
    {
        delete[] OriginalArray;
        _Size = 0;
        OriginalArray = new T[_Size];
    }
    // thre
    //void DeleteItemAt(int index)
    //{
    //    // My solution
    //    if (Index < 0 || Index >= _Size)
    //    {
    //        return;
    //    }
    //    _Size--;
    //    _TempArray = new T[_Size];

    //    for (int i = 0; i < _Size; i++)
    //    {
    //        int Shift = i;
    //        if (i > index)
    //        {
    //            Shift++;
    //        }
    //        if (i == index)
    //        {
    //            Shift++;
    //        }
    //        _TempArray[i] = OriginalArray[Shift];
    //        Shift++;
    //    }
    //    
    //    delete[] OriginalArray;  //Delete All original items

    //    OriginalArray = _TempArray;  // get the copy items
    //}
    bool DeleteItemAt(int index)
    {
        // prof solution
        if (index >= _Size || index < 0)
        {
            return false;
        }

        _Size--;

        _TempArray = new T[_Size];

        //copy all before index
        for (int i = 0; i < index; i++)
        {
            _TempArray[i] = OriginalArray[i];
        }

        //copy all after index
        for (int i = index + 1; i < _Size + 1; i++)
        {
            _TempArray[i - 1] = OriginalArray[i];
        }

        delete[] OriginalArray;
        OriginalArray = _TempArray;
        return true;

    }
    void DeleteFirstItem()
    {
        if (_Size == 0)
            return;
        DeleteItemAt(0);
    }
    void DeleteLastItem()
    {
        if (_Size == 0)
            return;
        DeleteItemAt(_Size-1);     
    }
    int Find(T Val)
    {
        for (int i = 0; i < _Size ; i++)
        {
            if (OriginalArray[i] == Val)
                return i;
        }
        return -1;
    }

    bool DeleteItem(T Val)
    {
        int index = Find(Val);

        if (index == -1)
            return false;

        DeleteItemAt(index);
        return true;
    }

    bool InsertAt(T index, T Val)
    {
        // check the conditions in the next time
        if (index > _Size || index < 0)
        {
            return false;
        }
        _Size++;
        _TempArray = new T[_Size];

        for (int i = 0; i < index; i++)
        {
            _TempArray[i] = OriginalArray[i];
        }
        _TempArray[index] = Val;  // insert Value after the index

        for (int i = index; i < _Size-1; i++)
        {
            _TempArray[i+1] = OriginalArray[i];
        }

        delete[] OriginalArray;
        OriginalArray = _TempArray;
        return true;
    }
    
   
    void InsertAtBeginning(T value)
    {

        InsertAt(0, value);

    }


    bool InsertBefore(T index, T value)
    {
        if (index < 1)
            return InsertAt(0, value);
        else
            return InsertAt(index - 1, value);

    }

    bool InsertAfter(T index, T value)
    {
        if (index >= _Size)
            return InsertAt(_Size - 1, value);
        else
            return InsertAt(index + 1, value);

    }

   bool InsertAtEnd(T value)
    {

        return InsertAt(_Size, value);

    }
};

