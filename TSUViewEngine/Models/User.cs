using System.ComponentModel.DataAnnotations;



namespace TSUViewEngine.Models

{



    public class User

    {



        public int Id { get; set; }



        [Required]

        public string Name { get; set; }



        [Required]

        public string Lastname { get; set; }



        [Required(ErrorMessage = "ველი სავალდებულოა")]

        [DataType(DataType.EmailAddress)]

        [EmailAddress(ErrorMessage = "ელ. ფოსტის მისამართი არ არის ვალიდური")]

        public string Email { get; set; }



        [Required(ErrorMessage = " პაროლი სავალდებულოა")]

        [DataType(DataType.Password)]

        [StringLength(20, ErrorMessage = "პაროლი უნდა შედგებოდეს მინიმუმ 3ციფრისგან", MinimumLength = 3)]



        public string Password { get; set; }



        [Display(Name = "დაადასტურე პაროლი")]

        [DataType(DataType.Password)]

        [Required(ErrorMessage = "paroli savaldebuloa")]

        [Compare("Password", ErrorMessage = "პაროლები არ არის ერთნაირი,სცადეთ ავიდან")]





        public string PasswordConfirmation { get; set; }



    }

}