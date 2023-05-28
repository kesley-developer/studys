// length
var arr=[1,2,3,4,5,6];
console.log("Characters in array: "+arr.length);

// push
var arr=[1,2,3,4,5,6,7];
arr.push(8);
console.log(arr);

// pop
var arr=[1,2,3,4,5,6,7,8,9,10,11];
arr.pop();
console.log(arr);

// unshift
var arr=[1,2,3,4,5];
arr.unshift(0);
console.log(arr);

// shift
var arr=[0,1,2,3,4,5];;
arr.shift();
console.log(arr);

// isArray
var arr=5;
console.log(Array.isArray(arr));

// splice
var arr=[1,2,3,5,6];
arr.splice(3,0,4);
console.log(arr);

// join
var arr=["Hello","My","Friend"];
console.log(arr.join(" "));

// reverse
var arr=[0,1,2,3,4,5];
arr.reverse();
console.log(arr);