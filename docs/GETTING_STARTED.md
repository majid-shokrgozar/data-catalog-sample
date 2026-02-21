# Getting Started

## Introduction
This guide provides you with a comprehensive overview of how to get started with the data catalog sample project. Whether you are a developer, tester, or a contributor, this document will help you set up your environment and understand the code structure.  

## Quick Start Instructions
1. **Clone the repository**:
   ```bash
   git clone https://github.com/majid-shokrgozar/data-catalog-sample.git
   cd data-catalog-sample
   ```  
2. **Install dependencies**:
   ```bash
   npm install  # or your package manager of choice
   ```
3. **Run the project**:
   ```bash
   npm start  # or the appropriate start command for your project
   ```

## Documentation Standards
- Ensure that all new code is accompanied by documentation in the corresponding files.
- Use Markdown format for documentation.
- Follow the **[conventional commit](https://www.conventionalcommits.org)** guidelines for commit messages.

## GitHub Issues Guidelines
- Always check for existing issues before creating a new one.
- Use labels to categorize issues (bug, feature, documentation, etc.).
- Provide a clear description of the issue and steps to reproduce it.

## CI/CD Pipeline Explanation
- The CI/CD pipeline automates the testing and deployment of the application.
- On every push to the main branch:
  - Tests will run automatically.
  - If all tests pass, the code will be deployed to the staging environment.

## Important File References  
- `src/`: Contains the main source code of the application.  
- `tests/`: Contains unit and integration tests.
- `docs/`: Contains all documentation related files.
- `CI.yml`: Configuration file for the CI/CD pipeline.

---

# راهنمای شروع به کار

## مقدمه
این راهنما نمای کلی کاملی از چگونگی شروع کار با پروژه نشانه‌گذاری داده‌ها را ارائه می‌دهد. چه شما یک توسعه‌دهنده، تست‌کننده یا مشارکت‌کننده باشید، این سند به شما در تنظیم محیط خود و درک ساختار کد کمک خواهد کرد.  

## دستورالعمل‌های سریع شروع
1. **کلون کردن مخزن**:
   ```bash
   git clone https://github.com/majid-shokrgozar/data-catalog-sample.git
   cd data-catalog-sample
   ```  
2. **نصب وابستگی‌ها**:
   ```bash
   npm install  # یا مدیر بسته‌ای که انتخاب کرده‌اید
   ```
3. **اجرای پروژه**:
   ```bash
   npm start  # یا دستور مناسب شروع برای پروژه شما
   ```

## استانداردهای مستندسازی
- اطمینان حاصل کنید که تمام کدهای جدید همراه با مستندات در فایل‌های مربوطه باشد.
- از فرمت Markdown برای مستندسازی استفاده کنید.
- از دستورالعمل‌های **[commit متعارف](https://www.conventionalcommits.org)** برای پیام‌های کمیت استفاده کنید.

## راهنمای مشکلات GitHub
- قبل از ایجاد یک مشکل جدید، همیشه مشکلات موجود را بررسی کنید.
- از برچسب‌ها برای دسته‌بندی مشکلات (باگ، ویژگی، مستندات و غیره) استفاده کنید.
- یک توصیف واضح از مشکل و مراحل تولید آن را ارائه دهید.

## توضیح خط لوله CI/CD
- خط لوله CI/CD آزمایش و استقرار برنامه را به طور خودکار انجام می‌دهد.
- با هر بار فشار به شاخه اصلی:
  - آزمایش‌ها به صورت خودکار اجرا خواهند شد.
  - اگر تمام آزمایش‌ها با موفقیت انجام شود، کد به محیط staging استقرار خواهد یافت.

## ارجاعات فایل‌های مهم  
- `src/`: شامل کد منبع اصلی برنامه است.  
- `tests/`: شامل آزمایش‌های واحد و ادغام است.
- `docs/`: شامل تمام فایل‌های مربوط به مستندات است.
- `CI.yml`: فایل پیکربندی برای خط لوله CI/CD.