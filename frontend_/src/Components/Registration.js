import React, {useState} from "react";
import axios from "axios";

function Registration(){
    const [name, setName] = useState('');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [phoneNo, setPhoneNo] = useState('');

    const handelSave = (e) => {
        e.preventDefault();
        console.log(name, email, password, phoneNo);
    }

    const myStyle = {
        borderTopLeftRadius: '.25rem',
        borderBottomLeftRadius: '.25rem'
    }

    return(
        <section className="h-100 bg-dark">
            <div className="container py-5 h-100">
                <div className="row d-flex justify-content-center align-items-center h-100">
                    <div className="col">
                        <div className="card card-registration my-4">
                            <div className="row g-0">
                                <div className="col-lg-6 d-none d-lg-block">
                                    <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/img4.webp"
                                        alt="Sample photo" className="img-fluid"
                                        style={myStyle} />
                                </div>
                                <div className="col-lg-6">
                                    <div className="card-body p-md-5 text-black">
                                        <h3 className="mb-4 text-uppercase">Student registration form</h3>

                                        <div className="row">
                                            <div className="col-md-12 mb-3">
                                                <div className="form-outline">
                                                    <input type="text" id="form3Example1m" className="form-control form-control-lg" 
                                                        onChange={(e) => setName(e.target.value)}/>
                                                    <label className="form-label" for="form3Example1m">Name</label>
                                                </div>
                                            </div>
                                        </div>

                                        <div className="form-outline mb-3">
                                            <input type="email" id="form3Example8" className="form-control form-control-lg" 
                                                onChange={(e) => setEmail(e.target.value)}/>
                                            <label className="form-label" for="form3Example8">Email</label>
                                        </div>

                                        <div className="form-outline mb-3">
                                            <input type="password" id="form3Example9" className="form-control form-control-lg" 
                                                onChange={(e) => setPassword(e.target.value)}/>
                                            <label className="form-label" for="form3Example9">Password</label>
                                        </div>

                                        <div className="form-outline mb-3">
                                            <input type="text" id="form3Example90" className="form-control form-control-lg" 
                                                onChange={(e) => setPhoneNo(e.target.value)}/>
                                            <label className="form-label" for="form3Example90">PhoneNo</label>
                                        </div>

                                        <div className="d-flex justify-content-end pt-3">
                                            <button type="button" className="btn btn-light btn-lg">Reset all</button>
                                            <button type="button" className="btn btn-warning btn-lg ms-2"
                                                onClick={(e) => handelSave(e)}>Submit form</button>
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