using System;

namespace ctest {
    class Book {
        private string title;
        private string author;

        public static int count = 0;

        public Book(){
            title = "Default Title";
            author = "Default Author";
            count++;
        }
        public Book(string title, string author) {
            this.title = title;
            this.author = author;
            count++;
        }
        public string getTitle() {
            return title;
        }
        public string getAuthor() {
            return author;
        }

        public string Title {
            get {
                return title;
            }
            set {
                title = value;
            } 
        }
    }
} 