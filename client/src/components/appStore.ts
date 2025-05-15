import { create } from "zustand";

interface StoreProps {
  isSignUp: boolean;
  setIsSignUp: (isSignUp: boolean) => void;
}

export const useAppStore = create<StoreProps>((set) => ({
  isSignUp: true,
  setIsSignUp: (isSignUp) => set({ isSignUp }),
}));
