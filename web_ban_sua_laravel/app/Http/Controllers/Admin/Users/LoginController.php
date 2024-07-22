<?php

namespace App\Http\Controllers\Admin\Users;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class LoginController extends Controller
{
    public function index()
    {
        return view('admin.users.login', [
            'title' => 'Dang nhap he thong'
        ]);
    }

    public function store(Request $request)
    {
        $this->validate($request, [
            'email' =>'required|email:filter',
            'password' => 'required',
        ]);

        if (Auth::attempt(['email' => $request->input('email'),
                'password' => $request->input('password'),
        ], $request->input('remember'))){
            return redirect()->route('admin');
        }

        Session::flash('error', 'tai khoan hoac password khong chinh xac');
        return redirect()->back();
    }
}
