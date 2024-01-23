import React from "react";

function Login(){
    return(
        <section className="vh-100">
            <div className="h-100 custom-body">
                <div className="row d-flex justify-content-center align-items-center h-100">
                    <div className="col">
                        <div className="card card-registration">
                            <div className="row g-0">
                                <div className="col-md-5 vh-100 d-flex flex-column justify-content-start align-items-center px-3 bg-info text-center py-5">
                                    <div className="row w-100">
                                        <div className="col-4">
                                            <div className="icon-box"><i class="ri-exchange-dollar-line"></i></div>
                                            <div className="icon-box"><i class="ri-money-dollar-box-line"></i></div>
                                            <div className="icon-box"><i class="ri-money-dollar-circle-fill"></i></div>
                                            <div className="icon-box"><i class="ri-money-dollar-box-fill"></i></div>
                                        </div>
                                        <div className="col-8">
                                            <div className="icon-box-description text-start center-vertically">Income Management</div>
                                            <div className="icon-box-description text-start center-vertically">Expense Management</div>
                                            <div className="icon-box-description text-start center-vertically">Budget Management</div>
                                            <div className="icon-box-description text-start center-vertically">Bill Management</div>
                                        </div>
                                    </div>
                                </div>
                                <div className="col-md-6">
                                    <div className="card-body d-flex flex-column justify-content-center align-items-center h-100">
                                        
                                        <h1 className="text-uppercase text-center py-2">Login</h1>

                                        <div className="form-outline py-4">
                                            <input type="text" id="form3Example1m" placeholder="User Name" className="form-control form-control-lg" 
                                                />
                                        </div>

                                        <div className="form-outline py-4">
                                            <input type="password" id="form3Example9" placeholder="Password" className="form-control form-control-lg" 
                                                />
                                        </div>
                                        

                                        <div className="remember-box d-flex justify-content-start">
                                            <input type="checkbox" className=""></input>
                                            <label>Remember Me</label>
                                        </div>

                                        <div className="d-flex justify-content-center py-3">
                                            <button type="button" className="btn btn-info"
                                                >Login</button>
                                        </div>

                                        <div className="">
                                            <p>Forgot Password ?</p>
                                        </div>

                                        <div className="row w-100 d-flex justify-content-center align-items-center text-center">
                                            <div className="col-5">
                                                <hr className="ruler"/>
                                            </div>
                                            <div className="col-2">
                                                or
                                            </div>
                                            <div className="col-5">
                                                <hr className="ruler"/>
                                            </div>
                                        </div>

                                        <div>
                                            <p className="">Create New Account</p>
                                        </div>

                                        <div className="d-flex justify-content-center py-3">
                                            <button type="button" className="btn btn-info"
                                                >Sign Up</button>
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

export default Login;