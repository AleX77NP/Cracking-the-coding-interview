// You are given two sorted arrays, A and B, and A has a large enough buffer at the end to hold B 
// Write a method to merge B into A in sorted order


let a = [1,3,5,7]
b = [2,4,6]

function merge(x, y) {
    let xl = x.length
    let yl = y.length

    let k = xl + yl - 1
    let i = xl - 1
    let j = yl - 1

    while (i >= 0 && j >= 0) {
        if(x[i] > y[j]) {
            x[k--] = x[i--]
        } else {
            x[k--] = y[j--]
        }
    }
    while(j >= 0) {
        x[k--] = y[j--]
    }

    return x
}

console.log(merge(a,b))


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