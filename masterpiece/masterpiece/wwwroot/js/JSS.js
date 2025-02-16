function loginBtn() {
    window.location.href = "/Home/Index";
}

function signupBtn() {
    window.location.href = "/Home/Index";
}

function HomeBtn() {
    window.location.href = "/Home/Index";
}
function ContactBtn() {
    window.location.href = "../contactUs.html";
}
// HomeBtn.document.addEventListener("click", function(){
//   window.location("../index");
// });

function ProfileBtn() {
    window.location.href = "../profile.html";
}

function AboutUsBtn() {
    window.location.href = "../aboutUs.html";
}

////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////////////////////
//انيميشن اللوجو
// // ///////////////////////////////////////////////////////////////////////////////////////////////////

document.addEventListener("DOMContentLoaded", function () {
    const div = document.getElementById("animatedDiv");

    // إظهار العنصر بعد تحميل الصفحة
    setTimeout(() => {
        div.classList.remove("hidden"); // إظهار العنصر
        div.classList.add("visible"); // تشغيل الانيميشن
    }); // تأخير 500 مللي ثانية قبل بدء الانيميشن
});

////////////////////////////////////////////////////////////////////////////////////////////////////
//انيميشن الناف بار
// ///////////////////////////////////////////////////////////////////////////////////////////////////

document.addEventListener("DOMContentLoaded", function () {
    const div = document.getElementById("animatedDiv2");

    // إظهار العنصر بعد تحميل الصفحة
    setTimeout(() => {
        div.classList.remove("hidden"); // إظهار العنصر
        div.classList.add("visible"); // تشغيل الانيميشن
    }, 10); // تأخير 500 مللي ثانية قبل بدء الانيميشن
});
////////////////////////////////////////////////////////////////////////////////////////////////////
//تأخير بين كل بطاقة وأخرى بمقدار 200 مللي ثانية صفحة الهوم
///////////////////////////////////////////////////////////////////////////////////////////////////

document.addEventListener("DOMContentLoaded", function () {
    const cards = document.querySelectorAll(".card");

    cards.forEach((card, index) => {
        setTimeout(() => {
            card.classList.add("visible");
        }, index * 70); // تأخير بين كل بطاقة وأخرى بمقدار 200 مللي ثانية
    });
});

//////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////
// كود عرض المحتوى حسب التصفية

document.addEventListener("DOMContentLoaded", function () {
    function filterCards(category) {
        document.querySelectorAll(".sections").forEach((card) => {
            if (category === "all" || card.dataset.category === category) {
                card.classList.remove("hidden");
            } else {
                card.classList.add("hidden");
            }
        });
    }

    document.querySelectorAll(".tab").forEach((tab, index) => {
        tab.addEventListener("change", function () {
            const categories = [
                "all",
                "Platforms",
                "games",
                "giftCard",
                "Bestsellers",
                "Microsoft products",
                "E-Learning",
                "Mobile Recharge",
                " monster hunter wilds",
                "cash Gift Card",
            ];
            filterCards(categories[index]);
        });
    });

    filterCards("all"); // عرض جميع البطاقات عند تحميل الصفحة
});

document.addEventListener("DOMContentLoaded", function () {
    setTimeout(() => {
        document.querySelectorAll(".tab_label").forEach((label, index) => {
            setTimeout(() => {
                label.classList.add("show");
            }, index * 50); // تأخير بين كل عنصر والآخر
        });
    }); // يبدأ بعد ثانية واحدة من تحميل الصفحة
});

//////////////////////////////////////////////////////////////////////////////
// كود صفحة البروفايل
//////////////////////////////////////////////////////////////////////////////

document.addEventListener("DOMContentLoaded", function () {
    setTimeout(() => {
        document.querySelectorAll(".feature-box").forEach((box, index) => {
            setTimeout(() => {
                box.classList.add("show");
            }, index * 50); // تأخير بين كل عنصر والآخر
        });
    }, 0); // يبدأ بعد ثانية واحدة من تحميل الصفحة
});

//////////////////////////////////////////////////////////////////////////////////
// صفحة البروفايل
//////////////////////////////////////////////////////////////////////////////////

function toggleBalance() {
    const balance = document.getElementById("balance-amount");
    const icon = document.querySelector(".toggle-balance");

    if (balance.textContent === "******") {
        balance.textContent = "$1,250.75"; // استبدل بالقيمة الحقيقية
        icon.classList.replace("fa-eye-slash", "fa-eye");
    } else {
        balance.textContent = "******";
        icon.classList.replace("fa-eye", "fa-eye-slash");
    }
}

////////////////////////////////////////////////////////
// مشاعدة المزيد في البروفايل
///////////////////////////////////////////////////

function toggleMore() {
    const moreContent = document.getElementById("moreContent");
    const button = document.querySelector(".show-more-btn");
    const icon = button.querySelector("i");

    if (
        moreContent.style.display === "none" ||
        moreContent.style.display === ""
    ) {
        moreContent.style.display = "block";
        button.querySelector("span").textContent = "Show Less";
        icon.classList.replace("fa-chevron-down", "fa-chevron-up");
    } else {
        moreContent.style.display = "none";
        button.querySelector("span").textContent = "Show More";
        icon.classList.replace("fa-chevron-up", "fa-chevron-down");
    }
}

////////////////////////////////////////////////////////////////////////////////
// كود البطاقات في الاباوت اس
///////////////////////////////////////////////////////////////////////////////

document.addEventListener("DOMContentLoaded", function () {
    let cards = document.querySelectorAll(".info-card");
    cards.forEach((card, index) => {
        setTimeout(() => {
            card.style.opacity = "1";
            card.style.transform = "scale(1)";
            card.style.animation = "fadeInUp 0.5s ease-out";
        }, index * 200);
    });
});
