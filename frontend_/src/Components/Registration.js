import React, {useState} from "react";
import axios from "axios";

function Registration(){
    const [name, setName] = useState('');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [phoneNo, setPhoneNo] = useState('');

    const handelSave = (e) => {
        e.preventDefault();
        // console.log(name, email, password, phoneNo);

        const url = `https://localhost:44347/api/Registration/Registration`;

        const data = {
            Name : name,
            Email : email,
            Password : password,
            PhoneNo : phoneNo
        }

        axios.post(url,data)
        .then((result) => {
            const dt = result.data;
        })
        .catch((error) => {
            console.log(error); 
        })
    }

    const myStyle = {
        borderTopLeftRadius: '.25rem',
        borderBottomLeftRadius: '.25rem'
    }

    

    return(
        <section className="h-100 bg-white">
            <div className="h-100">
                <div className="row d-flex justify-content-center align-items-center h-100">
                    <div className="col">
                        <div className="card card-registration">
                            <div className="row g-0">
                                <div className="col-lg-5 vh-100 d-flex flex-column justify-content-center align-items-center px-3 bg-info">
                                    <h1 className="left-box-header text-center py-3">Welcome Expensy</h1>
                                    <p className="text-center">Effortlessly manage your finances with our intuitive expense tracker. Stay in control, track spending,
                                        and achive financial goals seamlessly. Welcome to a smart way to handle your expenses.
                                    </p>
                                </div>
                                <div className="col-lg-6">
                                    <div className="card-body p-md-3 text-black d-flex flex-column justify-content-center align-items-center">
                                        <div className="row py-3">
                                            <div className="col-lg-6">
                                                <div className="d-flex justify-content-end">
                                                    <button type="button" className="btn btn-light"
                                                        onClick={(e) => handelSave(e)}>Sign In</button>
                                                </div>
                                            </div>
                                            <div className="col-lg-6">
                                                <div className="d-flex justify-content-start">
                                                    <button type="button" className="btn btn-primary"
                                                        onClick={(e) => handelSave(e)}>Register</button>
                                                </div>
                                            </div>
                                        </div>

                                        <h1 className="text-uppercase text-center py-3">Register</h1>

                                        <div className="py-4">
                                            <input type="text" id="form3Example1m" placeholder="Full Name" className="form-control form-control-lg" 
                                                    onChange={(e) => setName(e.target.value)}/>
                                        </div>

                                        <div className="form-outline py-4">
                                            <input type="email" id="form3Example8" placeholder="Email" className="form-control form-control-lg" 
                                                onChange={(e) => setEmail(e.target.value)}/>
                                        </div>

                                        <div className="form-outline py-4">
                                            <input type="password" id="form3Example9" placeholder="Password" className="form-control form-control-lg" 
                                                onChange={(e) => setPassword(e.target.value)}/>
                                        </div>

                                        <div className="form-outline py-4">
                                            <input type="password" id="form3Example90" placeholder="Confirm Password" className="form-control form-control-lg" 
                                                onChange={(e) => setPhoneNo(e.target.value)}/>
                                        </div>

                                        <div className="d-flex justify-content-center py-3">
                                            <button type="button" className="btn btn-primary"
                                                onClick={(e) => handelSave(e)}>Sign Up</button>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    )
}

export default Registration;