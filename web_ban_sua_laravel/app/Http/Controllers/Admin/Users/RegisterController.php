<?php

namespace App\Http\Controllers\Admin\Users;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use App\Models\User;

class RegisterController extends Controller
{
    public function index()
    {
        return view('admin.users.register', [
            'title' => 'Dang ky he thong'
        ]);
    }

    public function store(Request $request)
    {
        if($request->password != $request->retypePassword){
            session()->flash('error', 'Nhập lại mật khẩu không khớp!');
            return redirect()->back();
        }

        $user = User::where('email', $request->email)->get();

        if($user){
            session()->flash('error', 'Tài khoản đã tồn tại !');
            return redirect()->back();
        }

        User::create([
            'name'=>(string)$request->name,
            'email'=>(string)$request->email,
            'password'=>(string)$request->password,
            'is_admin'=> 1,
        ]);

        return redirect("/admin/users/login");
    }
}
