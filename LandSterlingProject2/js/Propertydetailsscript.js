function PropertyPrice(value){
    document.getElementById("property-price-span").innerHTML = "ADE " + value;
    CalculatePaymentAndInvestMent()
}
function LoanDuration(value){
    document.getElementById("Loan-Duration-span").innerHTML = value + " years";
    CalculatePaymentAndInvestMent()
}
function DownPayment(value){
    document.getElementById("Down-Payment-span").innerHTML = "ADE " + value;
    CalculatePaymentAndInvestMent();
}
function Interest(value){
    document.getElementById("Interest-span").innerHTML = value + " %"
    CalculatePaymentAndInvestMent();
}
function CalculatePaymentAndInvestMent() {
    alert("msg")
}