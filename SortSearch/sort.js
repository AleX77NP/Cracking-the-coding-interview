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
