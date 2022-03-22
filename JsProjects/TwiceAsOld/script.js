"use strict";

function digital_root(n) {
  let numToStrArr = String(n).split("");
  let number;
  let res = 0;

  numToStrArr.forEach((el) => {
    number = Number(el);
    res += number;
  });
  return res > 10 ? digital_root(res) : res;
}
