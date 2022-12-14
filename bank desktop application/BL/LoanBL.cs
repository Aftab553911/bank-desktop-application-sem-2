using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_desktop_application.BL
{
    class LoanBL
    {
        private string reason_of_loan;
        private float amount_loan;
        private float loan_installment;

        public string Reason_of_loan { get => reason_of_loan; set => reason_of_loan = value; }
        public float Amount_loan { get => amount_loan; set => amount_loan = value; }
        public float Loan_installment { get => loan_installment; set => loan_installment = value; }
        public LoanBL()
        {

        }
        public LoanBL(string reason_of_loan, float amount_loan, float loan_installment)
        {
            this.amount_loan = amount_loan;
            this.loan_installment = loan_installment;
            this.reason_of_loan = reason_of_loan;

        }
    }
}
