<div dir="rtl">
  
# حل مشکل جدا نمایش دادن متن تکست در یونیتی

این پکیج کوچیک متون فارسی که داخل کامپوننت Text یونیتی بصورت جدا جدا نمایش داده میشن رو به طور خودکار در شروع بازی درست میکنه


![](https://github.com/bitCoder0/FixPersianArabicUITextUnity3D/blob/master/output%20demo.jpg?raw=true)

  

برای این کار از یک اسکریپت کوچیک استفاده شده که  کامپوننت های تکست زیرمجموعه گیم آبجکت رو پیدا کنه و متنشون رو با کمک کد [Arabic Writer](https://github.com/Konash/arabic-support-unity)  درست کنه.

  
## نحوه استفاده


اول پکیج [PersianArabicTextUIFix.unitypackage](https://github.com/bitCoder0/FixPersianArabicUITextUnity3D/blob/master/PersianArabicTextUIFix.unitypackage)
 رو وارد پروژتون کنید یا محتویات پوشه Assets رو که بالا هست داخل پروژه کپی کنید

بعد اسکریپت PersianArabicFix.cs رو به گیم آجکتی که Canvas داره و تکستهاتون زیرمجوعه اونن اضافه کنید
![](https://github.com/bitCoder0/FixPersianArabicUITextUnity3D/blob/master/howTo.jpg?raw=true)  
تمام!تکست هایی که زیرمجوعه این Canvas هستند بطور خودکار توسط اسکریپت پیدا میشن

  
### نکته
این پکیج برای حل مشکل کامپوننت های تکست به کار میره اما راهکار های دیگه ای هم برای نوشتن فارسی/عربی داخل یونیتی وجود داره که اینجا به یکیشون اشاره شد

درصورت نیاز میتونید فایل اسکریپت رو طوری تغییر بدید که بین کل تکست های صفحه بگرده نه تکست های Canvas اما اون روش کمی پردازش بیشتری نیاز داره
</div>