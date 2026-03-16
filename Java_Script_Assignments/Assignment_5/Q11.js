class User {
    constructor(password) {
        this._password = password;
    }

    set password(value) {
        if (value.length >= 6) {
            this._password = value;
        } else {
            console.log("Password must be at least 6 characters");
        }
    }

    get password() {
        return this._password;
    }
}