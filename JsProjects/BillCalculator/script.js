'use.script';
//Code Challenge JS#1- Create a small function that calculates
//the total amount of a tip. If the bill is more then
//then 30$, bill * 0.15, if the bill is more then 300$, bill *0.2.
//Create 3 arrays: 1 - with the bills amount; 2 - with the tips amount
//3 - with the total amount of the bill.

const bills = [32, 88, 412, 65, 120, 336, 541];
const arrTips = [];
const arrTotalBill = [];

const calcBill = function (bill) {
    return bill > 30 && bill < 300 ? bill * .15 : bill * .2;
}
for (let i = 0; i < bills.length; i++) {
    const tip = calcBill(bills[i]);
    arrTips.push(tip);
    arrTotalBill.push(tip + bills[i]);
    console.log(`In the ${i + 1} bill I paid ${tip}$ in tips and the total amount of the bill was ${tip + bills[i]}$.`)
}
console.log(arrTips, bills, arrTotalBill);