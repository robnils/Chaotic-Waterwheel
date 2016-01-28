(* ::Package:: *)

BeginPackage["angleSimulator`"];
angleSimulator::usage="enter staring value and number of simulation steps";
textw::usage="ss";
(*private*)
Begin["`Private`"];
newstep[x_]:=Module[{tmp},
tmp=x+RandomReal[{-0.05,0.05}]*Pi;
If[tmp<0,tmp+=2*Pi,If[tmp>=2*Pi,tmp-=2*Pi]];
tmp]
newa[a_]:=a+RandomReal[{-0.1,0.1}]
neww[w_]:=w+RandomReal[{-0.5,0.5},w//Length]
angleSimulator[x0_,w_,n_]:=Map[Flatten,{NestList[newstep,x0,n],
NestList[newa,0,n],NestList[newa,0,n],NestList[neww,w,n]}//Transpose]
End[];
EndPackage[];
