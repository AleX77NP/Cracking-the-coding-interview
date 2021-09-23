// Given a matrix in which each row and each column is sorted, write a method to find an element in it

matrix = [
    [0,2,3,10],
    [1,3,8,11],
    [2,4,9,12]
]

function findElem(mat, elem) {
    let r = 0
    let c = mat[0].length - 1

    while(r < mat.length && c >= 0) {
        if(matrix[r][c] === elem) {
            return true
        } else if(matrix[r][c] > elem) {
            c--
        } else {
            r++
        }
    }
    return false
}

console.log(findElem(matrix, 8))


// Binary search

let simpleArr = [1,4,7,22,34,67,87,113,433]

function binarySearch(arr, start, end, elem, ) {
    let m = (start + (end-1)) / 2
    if (end >= 1) {
        if (arr[m] === elem) {
            return m
        }
        else if(arr[m] > elem) 
        return binarySearch(arr, start, m-1, elem)
        else
        return binarySearch(arr, m+1, end, elem)
    }
    else {
        return -1
    }
}

console.log(binarySearch(simpleArr, 0, simpleArr.length, 22))